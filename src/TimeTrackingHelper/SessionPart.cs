using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TimeTrackingHelper
{
    [Serializable]
    public class SessionPart
    {
        public readonly SessionPartType Type;
        public DateTime Start;
        public DateTime? End;

        [JsonIgnore]
        public TimeSpan Length => GetElapsedTime();
        

        public SessionPart(SessionPartType type) : this(DateTime.Now,null,type)
        {
        }

        [JsonConstructor]
        public SessionPart(DateTime start, DateTime? end, SessionPartType type)
        {
            Type = type;
            Start = start;
            End = end;
        }

        private TimeSpan GetElapsedTime()
        {
            return End?.Subtract(Start) ?? DateTime.Now.Subtract(Start);
        }

        public TimeSpan Stop()
        {
            End=DateTime.Now;;
            return GetElapsedTime();
        }
    }
}
