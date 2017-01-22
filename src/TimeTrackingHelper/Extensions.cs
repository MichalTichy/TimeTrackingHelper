using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackingHelper
{
    public static class Extensions
    {
        public static string ToText(this SessionStatus status)
        {
            switch (status)
            {
                case SessionStatus.Stopped:
                    return "Stopped";
                case SessionStatus.Working:
                    return "Working";
                case SessionStatus.Resting:
                    return "Resting";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static string ToText(this DateTime date)
        {
            return date.ToString(date.Date==DateTime.Today ? "t" : "g");
        }

        public static string ToText(this TimeSpan ts)
        {
            return $"{(int)ts.TotalHours}:{ts.Minutes}:{ts.Seconds}";
        }

        public static string ToText(this SessionPartType type)
        {
            switch (type)
            {
                case SessionPartType.Work:
                    return "Work";
                case SessionPartType.Rest:
                    return "Rest";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static ListViewItem ToListViewItem(this SessionPart sessionPart)
        {
            var listViewItem = new ListViewItem
            {
                BackColor = sessionPart.Type == SessionPartType.Work ? Color.Green : Color.Red,
                UseItemStyleForSubItems = true
            };
            listViewItem.SubItems[0].Text = sessionPart.Type.ToText();
            listViewItem.SubItems.Add(sessionPart.Start.ToText());
            listViewItem.SubItems.Add(sessionPart.End?.ToText());
            listViewItem.SubItems.Add(sessionPart.Length.ToText());

            return listViewItem;
        }
        public static Color GetColor(this SessionStatus status)
        {
            switch (status)
            {
                case SessionStatus.Stopped:
                    return Color.Black;
                case SessionStatus.Working:
                    return Color.Green;
                case SessionStatus.Resting:
                    return Color.Red;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
