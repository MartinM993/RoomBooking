using AssigmentBackend.Model;

namespace AssigmentBackend.Business.Interfaces
{
    public interface IRoomGetService
    {
        public Task<Room> GetAsync(int id);
        public Task<List<Room>> GetAllAsync();
    }
}
