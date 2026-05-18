namespace NoBeard.Learn.DotNet.ConsoleApp.Extensions;

internal static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime date)
    {
        return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
    }

    //public static bool IsPublicHoliday(this DateTime date)
    //{

    //}
}
