using System;

namespace Extension_Methods_Example
{
    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Friday || value.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekend(value);
        }
    }
}
