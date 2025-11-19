using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Domain
{
    public class AltWorkTypeRepository
    {
        public AltWorkType Add(string title, string description, string source)
        {

            AltWorkType result = null;

            if (!string.IsNullOrEmpty(title) &&
                !string.IsNullOrEmpty(description) &&
                !string.IsNullOrEmpty(source))
            {
                result = new AltWorkType()
                {
                    Title = title,
                    Description = description,
                    ImageSource = source
                };
                Persistence.altWorkTypes.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }


        public void Edit(int id, string title, string description, string source)
        {
            AltWorkType altWorkType = Get(id);

            if (altWorkType != null)
            {
                if (string.IsNullOrEmpty(title) &&
                    string.IsNullOrEmpty(description) &&
                    !string.IsNullOrEmpty(source))
                {
                    if (altWorkType.Title != title)
                        altWorkType.Title = title;
                    if (altWorkType.Description != description)
                        altWorkType.Description = description;
                    if (altWorkType.ImageSource != source)
                        altWorkType.ImageSource = source;
                }
                else
                    throw new ArgumentException("Not all arguments for exercise are valid");
            }
            else
                throw new ArgumentException("Content with ID " + id + " not found");
        }

        public void Delete(int id)
        {
            AltWorkType a = Get(id);
            if (a != null)
                Persistence.altWorkTypes.Remove(a);
            else
                throw new ArgumentException("Content with ID " + id + " not found");
        }

        public AltWorkType GetById(int id)
        {
            AltWorkType result = null;

            foreach (AltWorkType a in Persistence.altWorkTypes)
            {
                if (a.AltWorkTypeId == id)
                    result = a;
            }
            return result;
        }

    }
}
