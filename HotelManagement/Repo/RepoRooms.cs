using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Repo
{  
    public class RepoRooms : IRepoRooms
    {
        private readonly HotelManagementDBContext _context;

        public RepoRooms(HotelManagementDBContext context)
        {
            _context = context;
        }

        public async Task<Room> Add(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task Delete(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Room?> Get(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task<List<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync<Room>();
        }
            
        public async Task Update(int id, Room room)
        {
            var roomActual = await _context.Rooms.FindAsync(id);
            if (roomActual != null)
            {
                roomActual.RoomNumber = room.RoomNumber;
                roomActual.Type = room.Type;
                roomActual.PricePerNight = room.PricePerNight;
                roomActual.Status = room.Status;
                roomActual.Description = room.Description;

                await _context.SaveChangesAsync();
            }
        }

    }
}
