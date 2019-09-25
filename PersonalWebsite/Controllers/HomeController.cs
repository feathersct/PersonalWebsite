using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using PersonalWebsite.Services;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private IPWRepository _context;
        private IHttpContextAccessor _accessor;

        public HomeController(IPWRepository context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            _context.LogEvent("User accessed home index", _accessor.HttpContext.Connection.RemoteIpAddress.ToString());

            var events = _context.ReadAllEvents().ToList();
            var projects = _context.ReadAllProjects().ToList();

            var vm = new HomeViewModel()
            {
                Events = events,
                Projects = projects
            };

            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult ContactMe(string firstname, string lastname, string email, string subject)
        {
            var result = "Passed";

            SmtpClient smtpClient = new SmtpClient("live.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("claytonfeathers@live.com", "please21");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mailMessage = new MailMessage(email, "claytonfeathers@live.com");
            mailMessage.Subject = "Hello this is an email from claytonfeathers.net";
            mailMessage.Body = subject;

            smtpClient.Send(mailMessage);


            return Content(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
