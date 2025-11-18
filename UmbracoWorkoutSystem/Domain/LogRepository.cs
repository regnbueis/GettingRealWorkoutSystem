using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UmbracoWorkoutSystem.Domain
{
    public class LogRepository
    {
        public static List<Log> AllLogs;

        public static void InitializeRepository()
        {
            AllLogs = new List<Log>();
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
                    var saveObject = JsonConvert.SerializeObject(AllLogs);
                    sw.WriteLine(saveObject);
                }
            }
            catch
            {
                throw (new Exception("Save not succesful"));
            }
        }
    }
}
