using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarConsole
{
    public abstract class EventBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDefault { get; set; }
        public List<ContentBase> Contents { get; set; }

        public abstract bool CheckTime(DateTime dateTime);

        public abstract bool CheckDate(DateTime dateTime);
    }
}
