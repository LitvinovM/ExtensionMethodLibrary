using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionMillion
    {

        [DebuggerStepThroughAttribute]
        public static System.Int32 Million(this System.Int32 value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Int64 Million(this System.Int64 value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt32 Million(this System.UInt32 value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.UInt64 Million(this System.UInt64 value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Single Million(this System.Single value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Double Million(this System.Double value)
        {
            return value * 1000000;
        }

        [DebuggerStepThroughAttribute]
        public static System.Decimal Million(this System.Decimal value)
        {
            return value * 1000000;
        }
    }
}