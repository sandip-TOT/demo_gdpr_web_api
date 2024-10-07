using GdprCompliantWebApi.Data;
using GdprCompliantWebApi.Models;
using MongoDB.Driver;

namespace GdprCompliantWebApi.Repositories
{
    public class UserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(MongoContext context)
        {
            _users = context.Database.GetCollection<User>("Users");

             var indexKeys = Builders<User>.IndexKeys.Ascending(user => user.Email).Descending(user => user.DateOfBirth);
            _users.Indexes.CreateOne(new CreateIndexModel<User>(indexKeys));
        }

        public async Task CreateUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            await _users.InsertOneAsync(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _users.Find(user => true).ToListAsync();
        }
    }
}
