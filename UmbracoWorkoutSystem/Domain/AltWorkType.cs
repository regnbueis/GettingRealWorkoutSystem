using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UmbracoWorkoutSystem.Domain
{
    public class AltWorkType : IContent
    {
        // idCount maintains a counter assigned as Id to each new Person-object and 
        // then incremented so that each Person-object has a unique Id number
        private static int idCount = 300;

        public string Title { get; set; }
        public int AltWorkTypeId { get; }
        public string Description { get; set; }
        public string ImageSource { get; set; }

        public AltWorkType(string title, int id, string description, string imageSource)
        { 
            Title = title;
            AltWorkTypeId = idCount++;
            Description = description;
            ImageSource = imageSource;

            //kig også gerne på TusindfrydGUI for at være sikker på, hvordan constructoren skal fungere
        }

        public AltWorkType(string title, string description, string imageSource) :
            this(title, idCount++, description, imageSource) 
        {
        }

        public AltWorkType() 
        {
            AltWorkTypeId = idCount++;
        }

        public static void SetId(int id)
        {
            idCount = id;
        }
    }
}
