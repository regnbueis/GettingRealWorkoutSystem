using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem
{
    public class Exercise
    {
        public string Title { get; set; }
        public Guid ExerciseId { get; set; }
        public string Description { get; set; }
        public int TimeSpentInMinutes { get; set; }
        public string ImageSource { get; set; }
        public bool Favorite { get; set; }
        public Tag Tags { get; set; }

        public Exercise(string title, Guid exerciseId, string description, int timeSpentInMinutes, string imageSource, bool favorite, Tag tag1)
        {
            Title = title;
            ExerciseId = exerciseId;
            Description = description;
            TimeSpentInMinutes = timeSpentInMinutes;
            ImageSource = imageSource;
            Favorite = favorite;
            Tags = tag1; //vi har her valgt at hver øvelse kun kan have 1 tag for at begrænse kompleksiteten. Tilføj funktionalitet til flere tags hvis vi har tid
        }
    }
}
