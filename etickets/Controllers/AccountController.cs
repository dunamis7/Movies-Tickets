using etickets.Data;
using etickets.Data.ViewModels;
using etickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace etickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager; //work with user related data
        private readonly SignInManager<ApplicationUser> _signInManager; //perform tasks such as if a user is signed in etc.
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Login()
        {
            var response = new LoginVM();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)//Check if data annotaion condition on model are met
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);//check if user exists in our database by verifying the email
            if(user != null)//if user exists in database
            {
                //check for password
                var passwordCheck =await _userManager.CheckPasswordAsync(user, loginVM.Password);

                if (passwordCheck)//returns true if password exists in database
                {
                    var result =await _signInManager.PasswordSignInAsync(user, loginVM.Password, true, true);

                    if (result.Succeeded)
                    {
                       return RedirectToAction("Index", "Actors");//if sign in is successful, redirect to Actors/index
                    }
                }
                //if user entered a wrong password, return the ffg. message to the user
                TempData["Error"] = "Sorry wrong credentials. Please try again!";

                return View(loginVM);


            }

            //if user does not exist, return the ffg. message to the user
            TempData["Error"] = "Sorry wrong credentials. Please try again!";    

            return View(loginVM);

        }
    }






}
