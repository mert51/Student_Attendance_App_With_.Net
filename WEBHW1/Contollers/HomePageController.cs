using Microsoft.AspNetCore.Mvc;
using WEBHW1.Models;
namespace WEBHW1.Controllers
{


    public class HomePageController : Controller
    {


        public  IActionResult Home()
        {
            return View(Repository.GetGuests());

        }


    }
}