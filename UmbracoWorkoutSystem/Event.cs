using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem
{
    public class Event
    {
        public string Title { get; set; }
        public Guid EventId { get; set; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }
        public string ImageSource { get; set; }

        public Event(string title, Guid eventId, string description, DateTime date, string imageSource)
        {
            Title = title;
            EventId = eventId;
            Description = description;
            Date = date;
            ImageSource = imageSource;
        }
    }
}
