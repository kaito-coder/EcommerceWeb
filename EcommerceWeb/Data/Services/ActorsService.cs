using EcommerceWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbcontext _context;
        public ActorsService(AppDbcontext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
          await  _context.Actors.AddAsync(actor);
           await  _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id==id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n=> n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
