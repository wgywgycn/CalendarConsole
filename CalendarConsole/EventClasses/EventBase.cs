using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CalendarConsole
{
    public abstract class EventBase
    {
        public int Id { get; set; }
        /// <summary>
        /// 事件标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 是否为应用内置的事件
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// 事件的描述
        /// </summary>
        public List<ContentBase> Contents { get; set; }
        /// <summary>
        /// 检查时间是否一致
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public abstract bool CheckTime(DateTime dateTime);
        /// <summary>
        /// 检查日期是否一致
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public abstract bool CheckDate(DateTime dateTime);
    }
}
