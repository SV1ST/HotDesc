using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotDesc.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace HotDesc.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationContext _context;
        public AccountController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = await _context.Employees.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (employee == null)
                {
                    // добавляем пользователя в бд
                    employee = new Employee { Surname = model.Surname, Name = model.Name, Login = model.Login, Password = model.Password };
                    Role userRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "user");
                    if (userRole != null)
                        employee.Role = userRole;

                    _context.Employees.Add(employee);
                    await _context.SaveChangesAsync();

                    await Authenticate(employee); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = await _context.Employees
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (employee != null && employee.RoleId == 2)
                {
                    await Authenticate(employee); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else if( employee != null && employee.RoleId == 1)
                {
                    await Authenticate(employee);
                    return RedirectToAction("IndexAdmin", "Admin");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        private async Task Authenticate(Employee employee)
        {

            // создаем один claim
            var claims = new List<Claim>
            {   

                new Claim(ClaimsIdentity.DefaultNameClaimType, employee.Login),
                new Claim("Id", employee.Id.ToString()),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, employee.Role?.Name)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}