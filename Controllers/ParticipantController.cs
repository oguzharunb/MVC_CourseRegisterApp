using Microsoft.AspNetCore.Mvc;
using MVC_CourseRegisterApp.Models;

namespace MVC_CourseRegisterApp.Controllers
{
    public class ParticipantController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Models.Participant participant)
        {
            if (ModelState.IsValid == true)
            {
                Database.participants.Add(participant);
                return RedirectToAction("List");
            }
            return View();

        }

        public IActionResult List()
        {
            return View();
        }


    }
}
