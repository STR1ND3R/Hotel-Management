namespace HotelManagement.Repo;
using HotelManagement.Models;
public interface IRepoReservations
{
    Task<List<Reservation>> GetAll();
    Task<Reservation?> Get(int id);
    Task<Reservation> Add(Reservation reservation);
    Task Update(int id, Reservation reservation);
    Task Delete(int id);
}