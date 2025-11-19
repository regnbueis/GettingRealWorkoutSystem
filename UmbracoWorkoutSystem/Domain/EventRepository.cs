using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Domain
{
    public class EventRepository
    {
        private List<Event> events = new List<Event>();

        public Event Add(string title, string description, DateTime date, string source)
        {
            Event result = null;

            if (!string.IsNullOrEmpty(title) &&
                !string.IsNullOrEmpty(description) &&
                date != DateTime.MinValue &&
                !string.IsNullOrEmpty(source))
            {
                result = new Event()
                {
                    Title = title,
                    Description = description,
                    Date = date,
                    ImageSource = source
                };
                Persistence.events.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }

        public void Edit(int id, string title, string description, DateTime date, string source)
        {
            Event _event = Get(id);

            if (_event != null)
            {
                if (string.IsNullOrEmpty(title) &&
                    string.IsNullOrEmpty(description) &&
                    date != DateTime.MinValue &&
                    !string.IsNullOrEmpty(source))
                {
                    if (_event.Title != title)
                        _event.Title = title;
                    if (_event.Description != description)
                        _event.Description = description;
                    if (_event.Date != date)
                        _event.Date = date;
                    if (_event.ImageSource != source)
                        _event.ImageSource = source;
                }
                else
                    throw new ArgumentException("Not all arguments for exercise are valid");
            }
            else
                throw new ArgumentException("Event with ID " + id + " not found");
        }

        public void Delete(int id)
        {
            Event _event = Get(id);
            if (_event != null)
                Persistence.events.Remove(_event);
            else
                throw new ArgumentException("Event with ID " + id + " not found");
        }

        public Event GetById(int id)
        {
            Event result = null;

            foreach (Event e in Persistence.events)
            {
                if (e.EventId == id)
                    result = e;
            }
            return result;
        }

    }
}
