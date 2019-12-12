using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChristmasCalendar.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace ChristmasCalendar.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() {
            //using (HttpClient client = new HttpClient()) {
            //    HttpResponseMessage response = client.GetAsync("https://localhost:44315/api/facts").Result;
            //    response.EnsureSuccessStatusCode();
            //    var responseBody = response.Content.ReadAsStringAsync().Result;

            //    var model = JsonConvert.DeserializeObject<List<Facts>>(responseBody);
            //    return View(model);
            //}
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
