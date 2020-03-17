using System;

namespace CalendarConsole
{
    /// <summary>
    /// 单次提醒的事件
    /// </summary>
    public class SingleEvent : EventBase
    {
        public DateTime EvenTime { get; set; }
        public override bool CheckTime(DateTime time)
        {
            return time == EvenTime;
        }

        public override bool CheckDate(DateTime dateTime)
        {
            return dateTime.Date == EvenTime.Date;
        }
    }
}