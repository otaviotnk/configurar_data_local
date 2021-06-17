using System;
using TimeZoneConverter;

namespace ConfigureLocalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Necessita do pacote TimeZoneConverter

            var defaultDate = DateTime.UtcNow; //.Now

            var brazilianDate = GetLocalDate(defaultDate);

            Console.WriteLine("Data Servidor");
            Console.WriteLine(defaultDate);
            Console.WriteLine("-----------");
            Console.WriteLine("Data Local");
            Console.WriteLine(brazilianDate);
        }

        private static DateTime GetLocalDate(DateTime date)
        {
            var dateUtc = DateTime.SpecifyKind(date, DateTimeKind.Utc);
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Brazil/east");
            var localDate = TimeZoneInfo.ConvertTime(dateUtc, timeZoneInfo);

            return localDate;
        }
    }
}
