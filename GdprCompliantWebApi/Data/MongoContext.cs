using MongoDB.Driver;

namespace GdprCompliantWebApi.Data
{
    public class MongoContext
    {
        public IMongoDatabase Database { get; }

        public MongoContext(string connectionString)
        {
            var client = new MongoClient(connectionString);
            Database = client.GetDatabase("GDPR_DEMO");
        }
    }
}
