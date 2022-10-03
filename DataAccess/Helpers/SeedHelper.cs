namespace DataAccess.Data.Seed
{
    public static class SeedHelper
    {
        public static List<Guid> GenerateIds(int count)
        {
            var ids = new List<Guid>();

            do
            {
                ids.Add(Guid.NewGuid());
                count--;
            }
            while (count > 0);

            return ids;
        }

        public static string TimeSpanToFormatedString(TimeSpan timeSpan)
        {
            return timeSpan.ToString("mm\\:ss\\:ff");
        }
    }
}
