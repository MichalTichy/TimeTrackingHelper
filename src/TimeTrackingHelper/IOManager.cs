using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TimeTrackingHelper
{
    public static class IOManager
    {
        public static string SaveSession(Session session)
        {
            if (!session.Parts.Any())
                throw new ArgumentException("Provided session is empty!");

            var path = Path.Combine(GetPath(), session.Parts.First().Start.Ticks.ToString())+".json";
            
            using (var writer = new StreamWriter(path))
            {
                try
                {
                    var contentsToWriteToFile = JsonConvert.SerializeObject(session);
                    writer.Write(contentsToWriteToFile);
                }
                catch(Exception e)
                {
                    return null;
                }
                return path;
            }
        }
        
        public static Session LoadSession(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Session not found! {path}");

            using (var reader = new StreamReader(path))
            {
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Session>(fileContents);
            }
        }

        public static Session LoadLastSession()
        {
            var dir = new DirectoryInfo(GetPath());
            var lastSessionPath = dir.GetFiles().OrderByDescending(t => t.Name).FirstOrDefault();

            if (lastSessionPath == null)
                return null;

            var session = LoadSession(lastSessionPath.FullName);
            return session;
        }

        private static string GetPath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            
            string specificFolder = Path.Combine(folder, "TimeTrackingHelper");
            
            if (!Directory.Exists(specificFolder))
                Directory.CreateDirectory(specificFolder);

            return specificFolder;
        }
    }
}
