using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System.Net.Mail;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {

        public readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {

            return View();
        }        







    }

}
