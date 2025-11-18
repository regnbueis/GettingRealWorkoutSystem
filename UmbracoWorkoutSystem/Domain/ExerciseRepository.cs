using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UmbracoWorkoutSystem.Domain
{
    public class ExerciseRepository

    //overvej at lave et samlet repository til øvelser, mødeformer og events - evt. arbejd med inheritance som i Disaheim
    {
        /*private List<IContent> contents = new List<IContent>();

        public void InitializeRepository()
        {
            try
            {
                using StreamReader sr = new StreamReader("ExerciseRepository.txt");
                {
                    string line = sr.ReadLine();

                    int exerciseId = 0;
                    int eventId = 0;
                    int altWorkTypesId = 0;

                    while (line != null)
                    {
                        string[] parts = line.Split(',');

                        if (int.Parse(parts[1]) >= 100 && int.Parse(parts[1]) <= 299)
                        {
                            Exercise exercise = new Exercise(parts[0], int.Parse(parts[1]), parts[2], int.Parse(parts[3]), parts[4], parts[5]);

                            contents.Add(exercise);

                            if (exercise.ExerciseId > exerciseId)
                                exerciseId = exercise.ExerciseId;
                        }
                        else if (int.Parse(parts[1]) >= 400 && int.Parse(parts[1]) <= 899)
                        {
                            Event _event = new Event(parts[0], int.Parse(parts[1]), parts[2], DateTime.Parse(parts[3]), parts[4]);

                            contents.Add(_event);

                            if (_event.EventId > eventId)
                                eventId = _event.EventId;
                        }
                        else if (int.Parse(parts[1]) >= 300 && int.Parse(parts[1]) <= 399)
                        {
                            AltWorkType altWorkType = new AltWorkType(parts[0], int.Parse(parts[1]), parts[2], parts[3]);

                            contents.Add(altWorkType);

                            if (altWorkType.AltWorkTypeId > altWorkTypesId)
                                altWorkTypesId = altWorkType.AltWorkTypeId;
                        }
                    }
                    Exercise.SetId(exerciseId);
                    Event.SetId(eventId);
                    AltWorkType.SetId(altWorkTypesId);
                }
            }
            catch (IOException)
            {
                throw;
            }
            //vi starter med kun at arbejde med øvelser, men det er med vilje lavet,
            //så det er mega nemt at tilføje de andre klasser her
        }*/


        public Exercise AddExercise(string title, string description, int timeSpent, string source, string tags)
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
                Persistence.exercises.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }

        public void EditExercise(int id, string title, string description, int timeInMinutes, string source, string tags)
        {
            //er der en smart måde evt. at overloade metoden, så jeg ikke skal lave det her tre gange?
            //jeg kan heller ikke gennemskue hvordan man skal putte alle argumenterne ind uden at overdo it.
            Exercise exercise = Get(id);

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

            Persistence.Save();
        }


        public Exercise Get(int id)
        {
            Exercise result = null;

            foreach (Exercise e in Persistence.exercises)
            {
                if (e.ExerciseId == id)
                    result = e;
            }
            return result;
        }

        public void Delete(int id)
        {
            Exercise content = Get(id);
            if (content != null)
                Persistence.exercises.Remove(content);
            else
                throw new ArgumentException("Exercise with ID " + id + " not found");

        }

    }


}