using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Models;

namespace UmbracoWorkoutSystem.ViewModels
{
    public class MainViewModel
    {
        private int ChosenTag = 0;
        //TODO:
        //det her handler om, at vi ville prøve at gemme hvilket tag, brugeren har valgt,
        //så man i skiftet fra øvelsesviewet med listerne af hhv. tags og sorterede øvelser
        //kan gemme det valgte tag, og man i viewet, hvor man ser selve øvelsen, kan have
        //den tag-filtrerede liste med ude i siden. Vi må lige se, om det bliver relevant.
        //Ellers kan ChosenTag slettes uden videre.
        //load fra værdi og ændre værdi skal ligge som metoder på taglisten i UI.
        //on load eller got focus skal den tjekke chosentag
        //når brugeren vælger et tag skal chosentag ændres så det stemmer overens med valget

        public void StartUp()
        {
            Persistence.Persist.Initialize();
            Persistence.EmployeeRepository.Initialize();
            Persistence.LogRepository.Initialize();
        }

        private Event _nextEvent;

        public Event NextEvent
        {
            get { return _nextEvent; }
            set { _nextEvent = value; }
        }

        public void GetUpcomingEvent()
        {
            Event nextEvent = EventController.UpcomingEvent();
            NextEvent = nextEvent;
        }

    }
}
