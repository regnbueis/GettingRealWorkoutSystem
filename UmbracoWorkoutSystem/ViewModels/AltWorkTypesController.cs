using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Persistence;
using UmbracoWorkoutSystem.Models;

namespace UmbracoWorkoutSystem.ViewModels
{
    public class AltWorkTypesController
    {
        public List<AltWorkType> GetAllAltWorkTypes()
        {
            List<AltWorkType> result = AltWorkTypeRepository.GetAll();

            return result;
        }
    }
}
