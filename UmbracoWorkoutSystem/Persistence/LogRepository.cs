using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UmbracoWorkoutSystem.Models;

namespace UmbracoWorkoutSystem.Persistence
{
    public static class LogRepository
    {
        public static List<Log> AllLogs = new List<Log>();

        public static void Initialize()
        {
            try
            {
                int logId = 0;

                using StreamReader sr = new StreamReader("LogPersistence.txt");
                {
                    string line = sr.ReadLine();

                    List<Log> result = JsonConvert.DeserializeObject<List<Log>>(line);

                    foreach (Log log in result)
                    {
                        if (log.LogInstanceId > logId)
                            Log.SetId(logId);
                    }

                    AllLogs = result;
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static void Save()
        {
            try
            {
                using StreamWriter sw = new StreamWriter("LogPersistence.txt");
                {
                    string saveObject = JsonConvert.SerializeObject(AllLogs);
                    sw.WriteLine(saveObject);
                }
            }
            catch
            {
                throw new Exception("Save not succesful");
            }
        }

        public static Log Add(DateTime setTime, int employeeId, int exerciseId, int logType)
        {
            Log result = null;

            if (employeeId >= 0 &&
                exerciseId >= 0 &&
                logType >= 0)
            {
                result = new Log()
                {
                    LogSetTime = setTime,
                    EmployeeId = employeeId,
                    ExerciseId = exerciseId,
                    LogTypeId = logType
                };
                AllLogs.Add(result);
                Save();
            }
            else
                throw new ArgumentException("Not all arguments are valid");
            
            return result;

        }




    }
}
