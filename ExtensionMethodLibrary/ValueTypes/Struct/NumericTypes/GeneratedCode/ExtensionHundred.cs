using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionHundred
    {

        [DebuggerStepThroughAttribute]
        public static System.Int32 Hundred(this System.Int32 value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.Int64 Hundred(this System.Int64 value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt32 Hundred(this System.UInt32 value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt64 Hundred(this System.UInt64 value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.Single Hundred(this System.Single value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.Double Hundred(this System.Double value)
        {
            return value * 100;
        }

        [DebuggerStepThroughAttribute]
        public static System.Decimal Hundred(this System.Decimal value)
        {
            return value * 100;
        }
    }
}