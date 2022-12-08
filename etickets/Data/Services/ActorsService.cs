using etickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) // Injecting Appdbcontext class to actors service
        {
            _context = context;
        }

        //add a new actor to the database
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync(); 
        }

        public async Task DeleteActorAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id); //Looks for the actor with the id passed
            _context.Actors.Remove(result); //remove the actor from the database
            await _context.SaveChangesAsync(); //save the changes in the database
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var results = await _context.Actors.ToListAsync(); //TolistAsync belongs to the microsoft.entityframecore library
            return results;
        }

        public async Task <Actor> GetbyIDAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);

            return result;  
        }

        public async Task<Actor> UpdateActorAsync(int id, Actor newActor)
        {
            
            _context.Update(newActor);
            await _context.SaveChangesAsync(); 
            return newActor;
        }
    }
}
