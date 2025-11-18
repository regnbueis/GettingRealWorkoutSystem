using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Domain
{
    public class Log
    {
        private static int idCount = 0;
        public int LogInstanceId { get; }
        public DateTime LogSetTime { get; set; }
        public int EmployeeId { get; set; }
        public int ExerciseId { get; set; }
        public int LogTypeId { get; set; } //Enums 1 = Performed, 2 = Favorited, 3 = Unfavorited

        public Log(int logId, DateTime logSetTime, int employeeId, int exerciseId, int logTypeId)
        {
            LogInstanceId = logId;
            LogSetTime = logSetTime;
            EmployeeId = employeeId;
            ExerciseId = exerciseId;
            LogTypeId = logTypeId;
        }

        public Log(DateTime logSetTime, int employeeId, int exerciseId, int logTypeId) :
            this(idCount++, logSetTime, employeeId, exerciseId, logTypeId)
        { }

        public static void SetId(int id)
        {
            idCount = id;
        }
    }
}