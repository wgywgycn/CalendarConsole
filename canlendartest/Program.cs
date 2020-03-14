using System;
using System.Globalization;
using System.Threading;

namespace canlendartest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var now = DateTime.Now;


            var mycul = CultureInfo.CreateSpecificCulture("zh-cn");
            //mycul.DateTimeFormat.Calendar = new ChineseLunisolarCalendar();

            CultureInfo jaJP = CultureInfo.CreateSpecificCulture("ja-JP");
            jaJP.DateTimeFormat.Calendar = new JapaneseCalendar();
        }
    }
}
