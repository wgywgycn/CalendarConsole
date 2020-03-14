﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarConsole
{
    public class MultiEvent : EventBase
    {
        public List<DateTime> EventTimes { get; set; }
        public override bool CheckTime(DateTime time)
        {
            return EventTimes.Contains(time);
        }

        public override bool CheckDate(DateTime dateTime)
        {
            return EventTimes.Any(s => s.Date == dateTime.Date);
        }
    }
}