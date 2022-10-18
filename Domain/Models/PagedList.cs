using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace Domain.Models
{
    public class PagedList<T>
    {
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public List<T> Items { get; set; }
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalRecords = count;
            var totalPages = ((double)count / (double)pageSize);
            TotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            Items = items;
        }
        public static async Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }

        public static async Task<PagedList<T>> ToPagedListAsync<TDocument, TProjection>(IFindFluent<TDocument, T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountDocumentsAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Limit(pageSize).ToListAsync();

            return new PagedList<T>(items, (int)count, pageNumber, pageSize);
        }

        public static async Task<PagedList<T>> ToPagedListAsync<T>(IAggregateFluent<T> source, int pageNumber, int pageSize)
        {
            var items = await source.Skip((pageNumber - 1) * pageSize).Limit(pageSize).ToListAsync();
            var count = items.Count;

            return new PagedList<T>(items, (int)count, pageNumber, pageSize);
        }
    }
}
