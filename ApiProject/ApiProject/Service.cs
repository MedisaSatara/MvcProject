using ApiProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject
{
    public class Service
    {
        SportsEventsContext db = new SportsEventsContext();


        public List<Event> ListOfEvents()
        {
            List<Event> e = db.Events.ToList();
            if (e != null)
            {
                return e;
            }
            else
            {
                throw new Exception("There are not events!");
            }
        }
        public List<Event> ListOfEventsById(int eventId)
        {
            List<Event> listEvents = db.Events.Where(x => x.Id == eventId).ToList();
            if (listEvents.Count() != null)
            {
                return listEvents;
            }
            else
            {
                throw new Exception("Event with that Id doesn't exist");
            }
        }
        public List<Event> ListOfEventsBySport(string sport)
        {
            List<Event> listEvents = db.Events.Where(x => x.Sport == sport).ToList();
            if (listEvents.Count() != 0)
            {
                return listEvents;
            }
            else
            {
                throw new Exception("Event in that sport doesn't exist");
            }
        }
        public List<Event> ListOfEventsByCompetition(string competition)
        {
            List<Event> listEvents = db.Events.Where(x => x.Competition == competition).ToList();
            if (listEvents.Count() != 0)
            {
                return listEvents;
            }
            else
            {
                throw new Exception("Event in that competition doesn't exist");
            }

        }

        public List<Event> ListOfEventsByCategory(string category)
        {
            List<Event> listEvents = db.Events.Where(x => x.Category == category).ToList();
            if (listEvents.Count() != 0)
            {
                return listEvents;
            }
            else
            {
                throw new Exception("Event in that category doesn't exist");
            }

        }
    }
}

