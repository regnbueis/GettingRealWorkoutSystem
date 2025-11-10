using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem
{
    public class AltWorkType
    {
        public string Title { get; set; }
        public Guid AltWorkTypeId { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }

        public AltWorkType(string title, Guid altWorkTypeId, string description, string imageSource)
        { 
            Title = title;
            AltWorkTypeId = altWorkTypeId;
            Description = description;
            ImageSource = imageSource;
        }
    }
}
