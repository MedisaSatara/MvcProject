using ApiProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        Service service = new Service();

        [Route("GetAllEvents")]
        [HttpGet]
        public List<Event> GetAllEvents()
        {
            return service.ListOfEvents();
        }
        [Route("GetEventsById/eventId={eventId}")]
        [HttpGet]
        public List<Event> GetEventsById(int eventId)
        {
            return service.ListOfEventsById(eventId);
        }
        [Route("GetEventsBySport/sport={sport}")]
        [HttpGet]
        public List<Event> GetEventsBySport(string sport)
        {
            return service.ListOfEventsBySport(sport);
        }
        [Route("GetEventsByCompetition/competition={competition}")]
        [HttpGet]
        public List<Event> GetEventsByCompetition(string competition)
        {
            return service.ListOfEventsByCompetition(competition);
        }

        [Route("GetEventsByCategory/category={category}")]
        [HttpGet]
        public List<Event> GetEventsByCategory(string category)
        {
            return service.ListOfEventsByCategory(category);
        }


    }
}
