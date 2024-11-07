using AssigmentBackend.Database;
using AssigmentBackend.Model;

namespace AssigmentBackend.Business
{
    public class RoomGetService
    {
        private readonly DbContext _dbContext;

        public RoomGetService()
        {
            _dbContext = new DbContext();
        }

        public async Task<Room> GetAsync(int id)
        {
            return this._dbContext.Rooms.First(x => x.Id == id);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return this._dbContext.Rooms.ToList();
        }
    }
}
