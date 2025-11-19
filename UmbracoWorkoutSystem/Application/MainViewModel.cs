using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Domain;

namespace UmbracoWorkoutSystem.Application
{
    public class MainViewModel
    {
        public int ChosenTag = 0;
        //TODO:
        //load fra værdi og ændre værdi skal ligge som metoder på taglisten i UI.
        //on load eller got focus skal den tjekke chosentag
        //når brugeren vælger et tag skal chosentag ændres så det stemmer overens med valget

        public void StartUp()
        {
            Persistence.Persist.InitializeRepository();
        }

    }
}
