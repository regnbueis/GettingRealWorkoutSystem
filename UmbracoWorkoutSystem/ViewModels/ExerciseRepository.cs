using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Models;

namespace UmbracoWorkoutSystem.ViewModels
{
    public class ExerciseRepository
    {
        private List<Exercise> exercises = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            exercises.Add(exercise);
        }

        public void EditExercise()
        {
            
        }

        public void DeleteExercise(Exercise exercise)
        {
            exercises.Remove(exercise);
        }

        public void GetById(Guid id)
        {
            Exercise result = new Exercise();

            foreach (Exercise exercise in exercises)
            {
                if (exercise.ExerciseId == id)
                    result = exercise;
            }
        }
    }
}
