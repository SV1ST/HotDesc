using HotDesc.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Controllers
{
    [Authorize(Roles = "user")]
    public class HomeController : Controller
    {
        private readonly IWorkplaceRepository _workplaceRepository;
        private readonly IReservationRepository _reservationRepository;
        public HomeController(IWorkplaceRepository workplaceRepository, IReservationRepository reservationRepository)
        {
            _workplaceRepository = workplaceRepository;
            _reservationRepository = reservationRepository;
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
        public async Task<IActionResult> Index()
        {
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpGet]
        public async Task<IActionResult> Book()
        {
            return View(await _workplaceRepository.GetBookData());
        }
        [HttpPost]
        public async Task<IActionResult> Book(int workplaces, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook)
        {
            var userHold = User.Identity.Name;

            await _reservationRepository.Book(workplaces, userHold, mouse, keyboard, systemUnit, monitor, notebook);
            return View(await _workplaceRepository.GetBookData());
        }
        [HttpGet]
        public async Task<IActionResult> DeleteReservationForUser()
        {
            int fold = Convert.ToInt32(User.Claims.First(x => x.Type == "Id").Value);
            return View(await _reservationRepository.DeleteReservationForUser(fold));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteReservationForUser(int id)
        {
            int fold = Convert.ToInt32(User.Claims.First(x => x.Type == "Id").Value);
            await _reservationRepository.DeleteReservationForUser(id, fold);

            return View(await _reservationRepository.DeleteReservationForUser(fold));
        }

    }
}