using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UmbracoWorkoutSystem.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UmbracoWorkoutSystem.Persistence
{
    public class ExerciseRepository
    {
        public Exercise Add(string title, string description, int timeSpent, string source, string tags)
        {
            Exercise result = null;

            if (!string.IsNullOrEmpty(title) &&
                !string.IsNullOrEmpty(description) &&
                timeSpent >= 0 &&
                !string.IsNullOrEmpty(source) &&
                !string.IsNullOrEmpty(tags))
            {
                result = new Exercise()
                {
                    Title = title,
                    Description = description,
                    TimeSpentInMinutes = timeSpent,
                    ImageSource = source,
                    Tagging = tags
                };
                Persistence.Persist.exercises.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }

        public void Edit(int id, string title, string description, int timeInMinutes, string source, string tags)
        {
            Exercise exercise = GetById(id);

            if (exercise != null)
            {
                if (string.IsNullOrEmpty(title) &&
                    string.IsNullOrEmpty(description) &&
                    timeInMinutes >= 0 &&
                    !string.IsNullOrEmpty(source) &&
                    !string.IsNullOrEmpty(tags))
                {
                    if (exercise.Title != title)
                        exercise.Title = title;
                    if (exercise.Description != description)
                        exercise.Description = description;
                    if (exercise.TimeSpentInMinutes != timeInMinutes)
                        exercise.TimeSpentInMinutes = timeInMinutes;
                    if (exercise.ImageSource != source)
                        exercise.ImageSource = source;
                    if (exercise.Tagging != tags)
                        exercise.Tagging = tags;
                }
                else
                    throw new ArgumentException("Not all arguments for exercise are valid");
            }
            else
                throw new ArgumentException("Exercise with ID " + id + " not found");

            Persistence.Persist.Save();
        }

        public Exercise GetById(int id)
        {
            Exercise result = null;

            foreach (Exercise e in Persistence.Persist.exercises)
            {
                if (e.ExerciseId == id)
                    result = e;
            }
            return result;
        }

        public List<Exercise> GetListByTag(string tag)
        {
            List<Exercise> results = new List<Exercise>();

            foreach (Exercise e in Persistence.Persist.exercises)
            {
                if (e.Tagging.Contains(tag))
                    results.Add(e);
            }
            return results;
        }

        public void Delete(int id)
        {
            Exercise content = GetById(id);
            if (content != null)
                Persistence.Persist.exercises.Remove(content);
            else
                throw new ArgumentException("Exercise with ID " + id + " not found");

        }

    }


}