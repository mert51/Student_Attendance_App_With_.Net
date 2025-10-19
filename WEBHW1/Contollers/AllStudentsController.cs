using Microsoft.AspNetCore.Mvc;
using WEBHW1.Models;
namespace WEBHW1.Controllers
{

    [Route("AllStudents")]
    public class AllStudentsController : Controller
    {
        [Route("")]
        [Route("AllStudents")]
        public IActionResult AllStudents()
        {

            return View(Repository.GetGuests());
        }

        [Route("AttendanceInfo/{StudentId}")]
        public IActionResult Attendance(string StudentId)
        {
            var student = Repository.GetGuests().FirstOrDefault(s => s.StudentId == StudentId);

            if (student == null)
            {
                return NotFound();
            }

            ViewBag.StudentId = student.StudentId;
            ViewBag.Name = student.Name;
            ViewBag.Surname = student.Surname;
            ViewBag.SignedTime = TempData["SignedTime"];
            return View();
        }

    }
}