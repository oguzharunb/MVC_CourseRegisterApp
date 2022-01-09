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
            Pplist.participants.Add(participant);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View();
        }


    }
}
