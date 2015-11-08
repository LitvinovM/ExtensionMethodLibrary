using System;
using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionDuration
    {
        #region Int32

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.Int32 value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.Int32 value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.Int32 value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.Int32 value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.Int32 value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

        #region Int64

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.Int64 value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.Int64 value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.Int64 value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.Int64 value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.Int64 value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

        #region UInt32

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.UInt32 value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.UInt32 value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.UInt32 value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.UInt32 value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.UInt32 value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

        #region UInt64

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.UInt64 value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.UInt64 value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.UInt64 value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.UInt64 value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.UInt64 value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

        #region Single

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.Single value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.Single value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.Single value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.Single value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.Single value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

        #region Double

        [DebuggerStepThroughAttribute]
        public static TimeSpan Day(this System.Double value)
        {
            return TimeSpan.FromDays(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Hour(this System.Double value)
        {
            return TimeSpan.FromHours(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Minute(this System.Double value)
        {
            return TimeSpan.FromMinutes(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Second(this System.Double value)
        {
            return TimeSpan.FromSeconds(value);
        }

        [DebuggerStepThroughAttribute]
        public static TimeSpan Millisecond(this System.Double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        #endregion

    }
}