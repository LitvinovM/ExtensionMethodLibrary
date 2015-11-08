using System.Diagnostics;

namespace ExtensionMethodLibrary.ValueTypes
{
    public static partial class ExtensionMegabyte
    {

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.Int32 value)
        {
            return value / 1048576.0d;
        }

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.Int64 value)
        {
            return value / 1048576.0d;
        }

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.UInt32 value)
        {
            return value / 1048576.0d;
        }

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.UInt64 value)
        {
            return value / 1048576.0d;
        }

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.Single value)
        {
            return value / 1048576.0d;
        }

        [DebuggerStepThroughAttribute]
        public static double Megabyte(this System.Double value)
        {
            return value / 1048576.0d;
        }
    }
}