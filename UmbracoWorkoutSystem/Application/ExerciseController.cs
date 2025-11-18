using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Domain;

namespace UmbracoWorkoutSystem.Application
{
    class ExerciseController
    {
        public Tags ExerciseTagList()
        {
            Tags tags = new Tags();

            return tags;
        }

        public List<Exercise> ChooseMuscleGroup(string tag)
        {
            ExerciseRepository exerciseRepository = new ExerciseRepository();

            List<Exercise> exercises = exerciseRepository.GetListByTag(tag);

            return exercises;
        }

        public Exercise ChooseExercise(int id)
        {
            ExerciseRepository exerciseRepository = new ExerciseRepository();

            return exerciseRepository.GetById(id);
        }
    }
}
