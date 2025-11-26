using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Models;
using UmbracoWorkoutSystem.Persistence;

namespace UmbracoWorkoutSystem.ViewModels
{
    public class ExerciseController
    {
        public List<string> ExerciseTagList()
        {

            Tags tags = new Tags();

            return tags.Taglist;
        }

        public List<Exercise> ChooseMuscleGroup(string tag)
        {
            List<Exercise> exercises = ExerciseRepository.GetListByTag(tag);

            return exercises;
        }

        public Exercise ChooseExercise(int id)
        {
            return ExerciseRepository.GetById(id);
        }
    }
}
