using System;

namespace CalendarConsole
{
    /// <summary>
    /// 会循环的事件
    /// </summary>
    public class CycleEvent : EventBase
    {
        //TODO:
        public override bool CheckTime(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override bool CheckDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}