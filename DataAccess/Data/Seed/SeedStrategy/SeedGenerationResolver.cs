using Microsoft.Extensions.Configuration;

namespace DataAccess.Data.Seed.SeedStrategy
{
    public class SeedGenerationResolver
    {
        private readonly GridDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public SeedGenerationResolver(GridDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public ISeedStrategy GetStategy(SeedStrategies seedStrategies)
        {
            if(seedStrategies == SeedStrategies.SqlBulkCopy)
            {
                return new SqlBulkCopyStrategy(_configuration);
            }
            else if(seedStrategies == SeedStrategies.TVP)
            {
                return new TVPStrategy(_configuration);
            }
            else
            {
                return new BulkInsertStrategy(_dbContext);
            }
        }
    }
}
