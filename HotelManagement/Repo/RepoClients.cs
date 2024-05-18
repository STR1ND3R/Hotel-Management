using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Repo
{
    public class RepoClients : IRepoClients
    {
        private readonly HotelManagementDBContext _context;

        public RepoClients(HotelManagementDBContext context)
        {
            _context = context;
        }

        public async Task<Client> Add(Client persona)
        {
            await _context.Clients.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Clients.FindAsync(id);
            if (persona != null)
            {
                _context.Clients.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Client?> Get(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<List<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }
        
        public async Task Update(int id, Client persona)
        {
            var personaactual = await _context.Clients.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Name = persona.Name;
                personaactual.Email = persona.Email;
                personaactual.PhoneNumber = persona.PhoneNumber;
                await _context.SaveChangesAsync();
            }
        }

    }
}