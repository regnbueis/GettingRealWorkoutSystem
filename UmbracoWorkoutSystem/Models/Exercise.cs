using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Models
{
    public class Exercise
    {
        public string Title { get; set; }
        public Guid ExerciseId { get; set; }
        public string Description { get; set; }
        public int TimeSpentInMinutes { get; set; }
        public string ImageSource { get; set; }
        public bool Favorite { get; set; }
        public string Tagging {  get; set; }
        //public Tag Tags { get; set; } - fravalg af enums som tags, da det er nemmere for os at håndtere string separation, især ved flere tags

        public Exercise()
        { }
        public Exercise(string title, Guid exerciseId, string description, int timeSpentInMinutes, string imageSource, bool favorite, string tags)
        {
            Title = title;
            ExerciseId = exerciseId;
            Description = description;
            TimeSpentInMinutes = timeSpentInMinutes;
            ImageSource = imageSource;
            Favorite = favorite;
            Tagging = tags;
        }
    }
}
