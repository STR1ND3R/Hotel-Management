using HotelManagement.Models;

namespace HotelManagement.Repo
{
    public interface IRepoClients
    {
        Task<List<Client>> GetAll();
        Task<Client?> Get(int id);
        Task<Client> Add(Client persona);
        Task Update(int id, Client persona);
        Task Delete(int id);
    }
}