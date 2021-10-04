using HotDesc.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotDesc.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IWorkplaceRepository _workplaceRepository;
        private readonly IReservationRepository _reservationRepository;
        public AdminController(IWorkplaceRepository workplaceRepository, IReservationRepository reservationRepository)
        {
            _workplaceRepository = workplaceRepository;
            _reservationRepository = reservationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpGet]
        public async Task<IActionResult> DelReservations()
        {
            return View(await _reservationRepository.GetAllData());
        }
        [HttpPost]
        public async Task<IActionResult> DelReservations(int id)
        {
            await _reservationRepository.DeleteReservation(id);
            return View(await _reservationRepository.GetAllData());
        }
        [HttpGet]
        public async Task<IActionResult> CreateWorkplace()
        {
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpPost]
        public async Task<IActionResult> CreateWorkplace(string id)
        {
            await _workplaceRepository.CreateWorkpalce(id);
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpGet]
        public async Task<IActionResult> DeleteWorkplace()
        {
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpPost]
        public async Task<IActionResult> DeleteWorkplace(int id)
        {
            await _workplaceRepository.DeleteWorkplace(id);
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return View(await _workplaceRepository.GetAllData());
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, string description, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook)
        {
            await _workplaceRepository.Edit(id, description, mouse, keyboard, systemUnit, monitor, notebook);
            return View(await _workplaceRepository.GetAllData());
        }
    }

}
