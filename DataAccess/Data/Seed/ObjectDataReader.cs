using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace DataAccess.Data.Seed
{
    public class ObjectDataReader<TData> : IDataReader
    {
        private class PropertyAccessor
        {
            public List<Func<TData, object>> Accessors { get; set; }
            public Dictionary<string, int> Lookup { get; set; }
        }

        private static readonly Lazy<PropertyAccessor> s_propertyAccessorCache =
            new Lazy<PropertyAccessor>(() =>
            {
                var propertyAccessors = typeof(TData)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanRead)
                .Select((p, i) => new
                {
                    Index = i,
                    Property = p,
                    Accessor = CreatePropertyAccessor(p)
                })
                .ToArray();

                return new PropertyAccessor
                {
                    Accessors = propertyAccessors.Select(p => p.Accessor).ToList(),
                    Lookup = propertyAccessors.ToDictionary(
                    p => p.Property.Name, p => p.Index, StringComparer.OrdinalIgnoreCase)
                };
            });

        private static Func<TData, object> CreatePropertyAccessor(PropertyInfo p)
        {
            var parameter = Expression.Parameter(typeof(TData), "input");
            var propertyAccess = Expression.Property(parameter, p.GetGetMethod());
            var castAsObject = Expression.TypeAs(propertyAccess, typeof(object));
            var lamda = Expression.Lambda<Func<TData, object>>(castAsObject, parameter);
            return lamda.Compile();
        }

        private IEnumerator<TData> m_dataEnumerator;

        public ObjectDataReader(IEnumerable<TData> data)
        {
            m_dataEnumerator = data.GetEnumerator();
        }

        public void Close()
        {
            Dispose();
        }

        public int Depth => 1;

        public DataTable GetSchemaTable()
        {
            return null;
        }

        public bool IsClosed => m_dataEnumerator == null;

        public bool NextResult()
        {
            return false;
        }

        public bool Read()
        {
            if (IsClosed)
                throw new ObjectDisposedException(GetType().Name);
            return m_dataEnumerator.MoveNext();
        }

        public int RecordsAffected => -1;

        public int GetOrdinal(string name)
        {
            int ordinal;
            if (!s_propertyAccessorCache.Value.Lookup.TryGetValue(name, out ordinal))
                throw new InvalidOperationException("Unknown parameter name: " + name);
            return ordinal;
        }

        public object GetValue(int i)
        {
            if (m_dataEnumerator == null)
                throw new ObjectDisposedException(GetType().Name);
            return s_propertyAccessorCache.Value.Accessors[i](m_dataEnumerator.Current);
        }

        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        public long GetBytes(int i, long fieldOffset, byte[]? buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        public long GetChars(int i, long fieldoffset, char[]? buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicProperties)]
        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public int FieldCount => s_propertyAccessorCache.Value.Accessors.Count;

        public object this[string name] => throw new NotImplementedException();

        public object this[int i] => throw new NotImplementedException();
    }
}
