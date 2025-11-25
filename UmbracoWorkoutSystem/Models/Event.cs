using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Models
{
    public class Event : IContent
    {
        // idCount maintains a counter assigned as Id to each new Person-object and 
        // then incremented so that each Person-object has a unique Id number
        private static int idCount = 400;

        public string Title { get; set; }
        public int EventId { get; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }
        public string ImageSource { get; set; }

        public Event()
        {
            EventId = idCount++;
        }

        public Event(string title, int id, string description, DateTime date, string imageSource)
        {
            Title = title;
            EventId = idCount++;
            Description = description;
            Date = date;
            ImageSource = imageSource;
        }

        public Event(string title, string description, DateTime date, string imageSource) :
            this(title, idCount++, description, date, imageSource)
        {
        }
        public static void SetId(int id)
        {
            idCount = id;
        }
    }
}
