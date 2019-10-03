using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProCoach.Models;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Mail;
using System.Net;

namespace ProCoach.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SendMail("subject", "body", "receivermail");
            return View();

        }
        public void SendMail(string subject, string body, string receivermail)
        {

            var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("kprabhatrauniyar1@gmail.com", "Scooter@1991"),
                EnableSsl = true
            };
            client.Send("kprabhatrauniyar1@gmail.com", "anusha.tng@gmail.com", "HI", "This is pravat");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
