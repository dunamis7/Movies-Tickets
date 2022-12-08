using etickets.Data;
using etickets.Data.Services;
using etickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)// Injecting dbcontext class to actors controller
        {
            _service = service;
        }

        //Synchronous way of fetching data from the database
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data); // pass data from table to view as a list
        }

        //This action method returns the view which allows the user to enter the details for a new actor
        public IActionResult Create()
        {
            return View();
        }

        //This post request saves new data to the database
        [HttpPost]
        public async Task <IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Actor actor)
        {

            if (!ModelState.IsValid)// if model validations is false, return error messages in annotations
            {
                return View(actor);
            }
           
            //add new actor after model validations
           await  _service.AddAsync(actor);
            return RedirectToAction(nameof(Index)); // redirects to index action method after new actor have been added
        }

        //Return the details of one actor by id
        //Get:actor/details/id
        public async Task <IActionResult> Details(int id)
        {
            var actordetails = await _service.GetbyIDAsync(id);

            if (actordetails == null) //check if actors details been requested for is in the database
            {
                return View("Empty");
            }

            return View(actordetails);
        }




        //This action method returns the view which allows the user to upodate the details for a new actor
        public async Task <IActionResult> Edit(int id)
        {
            var actorsdetails = await _service.GetbyIDAsync(id);
            if(actorsdetails == null)
            {
                return View("Not found");
            }
            return View(actorsdetails);
        }

        //This post request saves new updated data to the database
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
           actor.ActorId = id; //Woboa do it well
            if (!ModelState.IsValid)// if model validations is false, return error messages in annotations
            {
                return View(actor);
            }

            //add new actor after model validations
            await _service.UpdateActorAsync(id,actor);
            return RedirectToAction(nameof(Index)); // redirects to index action method after new actor have been added
        }



        //This action method returns the view which allows the user to delete actor from the database
        public async Task<IActionResult> Delete(int id)
        {
            var actorsdetails = await _service.GetbyIDAsync(id);
            if (actorsdetails == null)
            {
                return View("Not found");
            }
            return View(actorsdetails);
        }

        //This post request saves new updated data to the database
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var actorsdetails = await _service.GetbyIDAsync(id);
            if (actorsdetails == null)
            {
                return View("Not found");
            }


            //add new actor after model validations
            await _service.DeleteActorAsync(id);
            return RedirectToAction(nameof(Index)); // redirects to index action method after new actor have been added
        }

    }
}
