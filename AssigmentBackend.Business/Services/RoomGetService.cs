using AssigmentBackend.Business.Interfaces;
using AssigmentBackend.Database;
using AssigmentBackend.Model;

namespace AssigmentBackend.Business.Services
{
    public class RoomGetService : IRoomGetService
    {
        private readonly DbContext _dbContext;

        public RoomGetService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Room> GetAsync(int id)
        {
            // CS1998 warning will appear if only return _dbContext.Rooms.First(x => x.Id == id)
            // because in-memory db is used, with this we can simulate/ mimic  an asynchronous execution
            // other solution can be to remove async from method defenition and return Task.FromResult(_dbContext.Rooms.First(x => x.Id == id))
            return await Task.Run(() => _dbContext.Rooms.First(x => x.Id == id));
        }
        
        public async Task<List<Room>> GetAllAsync()
        {
            return await Task.Run(() => _dbContext.Rooms.ToList());
        }
    }
}
