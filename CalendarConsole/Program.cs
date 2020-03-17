using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CalendarConsole
{
    class Program
    {
        private static ObservableCollection<EventBase> events = new ObservableCollection<EventBase>();

        class DayInfo
        {
            public DateTime Date { get; set; }

            public ObservableCollection<EventBase> Events { get; set; } = new ObservableCollection<EventBase>();
        }

        static void Main(string[] args)
        {
            init();

            var a = events.FirstOrDefault();
            var now = DateTime.Now;
            var days = new ObservableCollection<DayInfo>();
            var calendar = new GregorianCalendar();
            var thismonthdaycount = calendar.GetDaysInMonth(now.Year, now.Month);
            for (int i = 1; i <= thismonthdaycount; i++)
            {
                var d = new DateTime(now.Year, now.Month, i);
                var di = new DayInfo()
                {
                    Date = d,
                };
                foreach (var eventBase in events)
                {
                    if (eventBase.CheckDate(d))
                    {
                        di.Events.Add(eventBase);
                    }
                }
                days.Add(di);

            }



            Console.WriteLine("Hello World!");
        }

        private static void init()
        {
            var s = new SingleEvent()
            {
                Id = 1,
                EvenTime = DateTime.Now.Add(TimeSpan.FromSeconds(10)),
                Title = "first event",
                Contents = new List<ContentBase>()
                {
                    new TextContent(){Text = "first event description"}
                }
            };
            events.Add(s);
        }
    }
}
