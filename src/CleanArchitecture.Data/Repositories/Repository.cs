using MongoDB.Driver;

namespace CleanArchitecture.Data.Repositories
{
    public abstract class Repository<IAggregateRoot>
    {
        protected readonly IMongoCollection<IAggregateRoot> _collection;

        public Repository(IMongoDatabase database, string collectionName)
        {
            _collection = database.GetCollection<IAggregateRoot>(collectionName);
        }
    }
}
