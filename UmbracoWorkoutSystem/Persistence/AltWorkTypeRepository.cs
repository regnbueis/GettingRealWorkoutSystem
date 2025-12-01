using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Models;

namespace UmbracoWorkoutSystem.Persistence
{
    public static class AltWorkTypeRepository
    {
        public static AltWorkType Add(string title, string description, string source)
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
                Persistence.Persist.altWorkTypes.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }

        public static void Edit(int id, string title, string description, string source)
        {
            AltWorkType altWorkType = GetById(id);

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
                    throw new ArgumentException("Not all arguments are valid");
            }
            else
                throw new ArgumentException("Content with ID " + id + " not found");
        }

        public static void Delete(int id)
        {
            AltWorkType a = GetById(id);
            if (a != null)
                Persistence.Persist.altWorkTypes.Remove(a);
            else
                throw new ArgumentException("Content with ID " + id + " not found");
        }

        public static AltWorkType GetById(int id)
        {
            AltWorkType result = null;

            foreach (AltWorkType a in Persistence.Persist.altWorkTypes)
            {
                if (a.AltWorkTypeId == id)
                    result = a;
            }
            return result;
        }

        public static List<AltWorkType> GetAll()
        {
            return Persistence.Persist.altWorkTypes;
        }
    }
}
