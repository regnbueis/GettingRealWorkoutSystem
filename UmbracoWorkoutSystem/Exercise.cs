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
        public string Tag { get; set; }

        public Exercise(string title, Guid exerciseId, string description, int timeSpentInMinutes, string imageSource, bool favorite, string tag)
        {
            Title = title;
            ExerciseId = exerciseId;
            Description = description;
            TimeSpentInMinutes = timeSpentInMinutes;
            ImageSource = imageSource;
            Favorite = favorite;
            Tag = tag;
        }
    }
}
