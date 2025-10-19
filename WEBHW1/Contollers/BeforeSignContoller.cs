using Microsoft.AspNetCore.Mvc;
using WEBHW1.Models;

namespace WEBHW1.Controllers
{


    public class BeforeSignController : Controller
    {
        [HttpGet]
        public ActionResult Before()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Before(string StudentId)
        {
            Repository.UpdateSigned(StudentId);
            TempData["LastStudentId"] = StudentId;
            TempData["SignedTime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            return RedirectToAction("After", "AfterSign");


        }

    }
}
