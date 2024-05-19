using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Repo
{  
    public class RepoReservations : IRepoReservations
    {
        private readonly HotelManagementDBContext _context;

        public RepoReservations(HotelManagementDBContext context)
        {
            _context = context;
        }

        public async Task<Reservation> Add(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
            return reservation;
        }

        public async Task Delete(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Reservation?> Get(int id)
        {
            return await _context.Reservations.FindAsync(id);
        }

        public async Task<List<Reservation>> GetAll()
        {
            return await _context.Reservations.ToListAsync();
        }
            
        public async Task Update(int id, Reservation reservation)
        {
            var reservationActual = await _context.Reservations.FindAsync(id);
            if (reservationActual != null)
            {
                reservationActual.ClientId = reservation.ClientId;
                reservationActual.RoomId = reservation.RoomId;
                reservationActual.CheckInDate = reservation.CheckInDate;
                reservationActual.CheckOutDate = reservation.CheckOutDate;
                reservationActual.TotalPrice = reservation.TotalPrice;
                reservationActual.Status = reservation.Status;

                await _context.SaveChangesAsync();
            }
        }

    }
}