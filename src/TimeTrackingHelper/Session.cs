using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TimeTrackingHelper
{
    [Serializable]
    public class Session
    {
        [JsonProperty]
        private List<SessionPart> _parts = new List<SessionPart>();
        
        public IReadOnlyCollection<SessionPart> Parts => _parts.AsReadOnly();

        public SessionStatus CurrentStatus => GetCurrentStatus();

        public double Efficiency => CalculateEfficiency();

        public TimeSpan TotalTime => GetTotaRestTime() + GetTotalWorkingTime();
        public TimeSpan TotalWorkingTime => GetTotalWorkingTime();
        public TimeSpan TotalRestTime => GetTotaRestTime();
        public TimeSpan AverageRestTime => GetAverageRestTime();
        public TimeSpan AverageWorkTime => GetAverageWorkTime();
        public SessionPart CurrentSessionPart => GetCurrentSession();

        public SessionPart StartSessionPart(SessionPartType type)
        {
            var currentSession = GetCurrentSession();

            currentSession?.Stop();

            var sessionPart = new SessionPart(type);
            _parts.Add(sessionPart);

            IOManager.SaveSession(this);

            return sessionPart;
        }

        public void EndSession()
        {
            CurrentSessionPart.Stop();
            IOManager.SaveSession(this);
        }

        private SessionPart GetCurrentSession()
        {
            return _parts.SingleOrDefault(t => !t.End.HasValue);
        }

        private SessionStatus GetCurrentStatus()
        {
            if (Parts.Count == 0 || CurrentSessionPart==null)
                return SessionStatus.Stopped;

            return CurrentSessionPart.Type == SessionPartType.Work ? SessionStatus.Working : SessionStatus.Resting;
        }


        private double CalculateEfficiency()
        {
            if (_parts.Count == 0)
                return 0;

            double workingTimeRatio = (double)TotalWorkingTime.Ticks / TotalTime.Ticks;
            return workingTimeRatio * 100;
        }

        private TimeSpan GetTotalWorkingTime()
        {
            var total = new TimeSpan();
            foreach (var sessionPart in _parts.Where(t=>t.Type==SessionPartType.Work))
            {
                total = total.Add(sessionPart.Length);
            }
            return total;
        }
        private TimeSpan GetTotaRestTime()
        {
            var total = new TimeSpan();
            foreach (var sessionPart in _parts.Where(t=>t.Type==SessionPartType.Rest))
            {
                total = total.Add(sessionPart.Length);
            }
            return total;
        }

        private TimeSpan GetAverageWorkTime()
        {
            var count = Parts.Count(t => t.Type == SessionPartType.Work);
            if (count == 0)
                return new TimeSpan(0);

            var averageWorkTime = TotalWorkingTime.Ticks / count;
            return new TimeSpan(averageWorkTime);
        }

        private TimeSpan GetAverageRestTime()
        {
            var count = Parts.Count(t => t.Type == SessionPartType.Rest);
            if (count == 0)
                return new TimeSpan(0);

            var averageWorkTime = TotalRestTime.Ticks / count;

            return new TimeSpan(averageWorkTime);
        }
    }
}
