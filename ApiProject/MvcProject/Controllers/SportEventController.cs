using ApiProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MvcProject.Controllers
{
    public class SportEventController : Controller
    {
        SportsEventsContext db = new SportsEventsContext();
        Uri baseAddress = new Uri("https://localhost:44364/api");
        HttpClient client;
        public SportEventController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<EventsVM> list = new List<EventsVM>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Events/GetAllEvents").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<List<EventsVM>>(data);
            }
            return View(list);
        }


        public IActionResult Show(EventsVM x)
        {
            var sport = db.Events.Find(x.Sport);
            var events = new SportEventsVM
            {
                rows = db.Events.Where(s => s.Sport == sport.Sport)
                .Select(s => new SportEventsVM.Row
                {
                    EventId = s.Id,
                    TimeOfEvent = s.TimeOfEvent,
                    Opponents = s.Opponents,
                    Result = s.Result,
                    Status = s.Status,
                    Category = s.Category,
                    Competition = s.Competition,
                    Sport = s.Sport
                }).ToList()

            };
            return PartialView(Index());
        }
    }
}
