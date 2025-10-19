using Microsoft.AspNetCore.Mvc;
using WEBHW1.Models;
namespace WEBHW1.Controllers
{


    public class AfterSignController : Controller
    {
        [HttpGet]
        public IActionResult After()
        {
            var lastStudentId = TempData["LastStudentId"] as string;

            if (lastStudentId != null)
            {
                var lastStudent = Repository.LastSigned(lastStudentId);
                ViewBag.LastStudent = lastStudent;
            }

            return View(Repository.GetGuests());
        }


        [HttpPost]
        public ActionResult After(string StudentId)
        {
            Repository.UpdateSigned(StudentId);

            var lastStudent = Repository.LastSigned(StudentId);
            ViewBag.LastStudent = lastStudent;

            return View(Repository.GetGuests());
        }

    }


}
