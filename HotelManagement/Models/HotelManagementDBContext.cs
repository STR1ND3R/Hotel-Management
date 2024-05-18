using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

public class HotelManagementDBContext : DbContext
{
    public HotelManagementDBContext(DbContextOptions<HotelManagementDBContext> options) : base(options)
    {
        
    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
        
}