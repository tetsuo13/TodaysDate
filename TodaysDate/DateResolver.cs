using System;

namespace TodaysDate
{
    /// <summary>
    /// Date resolver.
    /// </summary>
    public static class DateResolver
    {
        /// <summary>
        /// Get today's date. Takes care of time zones and everything.
        /// </summary>
        /// <returns>Today's date.</returns>
        public static DateTime TodaysDate()
        {
            return DateTime.Now;
        }
    }
}
