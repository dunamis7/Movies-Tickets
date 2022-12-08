using etickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace etickets.Data.Services
{
    public class ActorMockService : IActorsService
    {
        public async Task AddAsync(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteActorAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var actors = new List<Actor>();
            actors.Add(new Actor
            {
                ActorId = 1,
                Bio = "Bio Information",
                FullName = "Antwi Bright"
            });

            actors.Add(new Actor
            {
                ActorId = 2,
                Bio = "Bio for Actor 2",
                FullName = "KwesiOwusu"
            });

            await Task.CompletedTask;
            return  actors;

        }

        public Task <Actor> GetbyIDAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task <Actor> UpdateActorAsync(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
