using System;
using System.Diagnostics;

namespace ExtensionMethodLibrary.Object
{
    public static class ExtensionObject
    {
        [DebuggerStepThrough]
        public static T ThrowExceptionIfNull<T>(this T obj) where T : class
        {
            if (null == obj)
            {
                var stackTrace = new StackTrace();
                throw new ArgumentNullException(
                    string.Format(stackTrace.GetFrame(1).GetMethod().Name));
            }
            return obj;
        }

        [DebuggerStepThrough]
        public static void IfNotNull<T>(this T obj, Action<T> action) where T : class
        {
            action.ThrowExceptionIfNull();

            if (obj != null)
            {
                action(obj);
            }
        }

        [DebuggerStepThrough]
        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func) where T : class
        {
            func.ThrowExceptionIfNull();

            return obj != null ? func(obj) : default(TResult);
        }

        [DebuggerStepThrough]
        public static T Self<T>(this T obj, Action<T> action) where T : class
        {
            action.ThrowExceptionIfNull();

            action(obj);
            return obj;
        }
    }
}
