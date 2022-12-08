using etickets.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace etickets.Data.Services
{
    public interface IActorsService
    {
        //Method signature to get all the actors from the database
       Task<IEnumerable<Actor>> GetAllAsync(); // Task<IEnumerable<Actor>> is the  asynchrronous return type of the method

        //Method signature to return a single actor
        Task<Actor> GetbyIDAsync(int id); // Actor is the return type. It return only one actor

        //Method signature to add data to the database
        Task AddAsync(Actor actor);

        //Method signature to update data in the database
        Task <Actor> UpdateActorAsync(int id, Actor newActor);

        //Method signature to delete data in the database
        Task DeleteActorAsync(int id);


    }
}
