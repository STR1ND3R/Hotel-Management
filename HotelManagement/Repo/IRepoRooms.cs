namespace HotelManagement.Repo;
using HotelManagement.Models;
public interface IRepoRooms
{
    Task<List<Room>> GetAll();
    Task<Room?> Get(int id);
    Task<Room> Add(Room room);
    Task Update(int id, Room room);
    Task Delete(int id);
}