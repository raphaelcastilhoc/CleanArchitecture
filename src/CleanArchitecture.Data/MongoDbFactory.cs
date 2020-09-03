using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace CleanArchitecture.Data
{
    public class MongoDbFactory
    {
        private readonly IConfiguration _configuration;

        public MongoDbFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IMongoDatabase GetDatabase()
        {
            var url = new MongoUrl(_configuration.GetConnectionString("Mongo"));
            var client = new MongoClient(url);
            var database = client.GetDatabase("HumanResources");

            var conventionPack = new ConventionPack {
                new IgnoreExtraElementsConvention(true)
            };

            ConventionRegistry.Register("IgnoreExtraElements", conventionPack, x => true);

            return database;
        }
    }
}
