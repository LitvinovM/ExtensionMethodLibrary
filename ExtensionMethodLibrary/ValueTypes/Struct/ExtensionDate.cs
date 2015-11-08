using System;

namespace ExtensionMethodLibrary.ValueTypes.Date
{
    public static class ExtensionDate
    {
        public static DateTime Ago(this TimeSpan time)
        {
            return DateTime.Now.Subtract(time);
        }

        public static DateTime Future(this TimeSpan time)
        {
            return DateTime.Now.Add(time);
        }
    }
}
