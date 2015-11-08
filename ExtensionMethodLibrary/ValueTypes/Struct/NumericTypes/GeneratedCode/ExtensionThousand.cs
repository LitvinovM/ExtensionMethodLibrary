using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionThousand
    {

        [DebuggerStepThroughAttribute]
        public static System.Int32 Thousand(this System.Int32 value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Int64 Thousand(this System.Int64 value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt32 Thousand(this System.UInt32 value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt64 Thousand(this System.UInt64 value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Single Thousand(this System.Single value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Double Thousand(this System.Double value)
        {
            return value * 1000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Decimal Thousand(this System.Decimal value)
        {
            return value * 1000;
        }
    }
}