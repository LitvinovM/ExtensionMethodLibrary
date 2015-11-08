using System;
using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionPercent
    {
        #region Int32

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Int32 value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Int32 value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region Int64

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Int64 value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Int64 value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region UInt32

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this UInt32 value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this UInt32 value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region UInt64

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this UInt64 value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this UInt64 value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region Single

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Single value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Single value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region Double

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Double value, System.Int32 percent)
        {
            return percent * 0.01 * value;
        }

        [DebuggerStepThroughAttribute]
        public static Double Percentage(this Double value, System.Double percent)
        {
            return percent * 0.01 * value;
        }

        #endregion

        #region Decimal

        [DebuggerStepThroughAttribute]
        public static Decimal Percentage(this Decimal value, System.Int32 percent)
        {
            return percent * 0.01M * value;
        }

        [DebuggerStepThroughAttribute]
        public static Decimal Percentage(this Decimal value, System.Double percent)
        {
            return (System.Decimal)percent * 0.01M * value;
        }

        #endregion

    }
}