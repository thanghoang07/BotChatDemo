using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotChatDemo1.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text;

namespace BotChatDemo1.Controllers
{
    public class HomeController : Controller
    {
        // Global values to hold the custom settings
        private static string _OcpApimSubscriptionKey;
        private static string _KnowledgeBase;
        // Get the CustomSettings using dependency injection
        public HomeController(
            IOptions<CustomSettings> CustomSettings)
        {
            // Set the custom values
            _OcpApimSubscriptionKey = CustomSettings.Value.OcpApimSubscriptionKey;
            _KnowledgeBase = CustomSettings.Value.KnowledgeBase;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
