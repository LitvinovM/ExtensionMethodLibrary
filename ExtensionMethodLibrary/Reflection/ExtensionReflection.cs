using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ExtensionMethodLibrary.Reflection
{
    public static class ExtensionReflection
    {
        #region Attribute

        [DebuggerStepThroughAttribute]
        public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this Type type, bool inherit) where TAttribute : Attribute
        {
            return (TAttribute[])type.GetCustomAttributes(typeof(TAttribute), inherit);
        }

        [DebuggerStepThroughAttribute]
        public static IEnumerable<TAttribute> GetAttributes<T, TAttribute>(this T obj, bool inherit) where TAttribute : Attribute
        {
            return (TAttribute[])(typeof(T).GetCustomAttributes(typeof(TAttribute), inherit));
        }

        [DebuggerStepThroughAttribute]
        public static TAttribute GetAttribute<T, TAttribute>(this T obj, bool inherit) where TAttribute : Attribute
        {
            return (TAttribute)(typeof(T).GetCustomAttributes(typeof (TAttribute), inherit)).Single();
        }

        [DebuggerStepThrough]
        public static TAttribute GetAttribute<T, TAttribute>(this Type type, bool inherit) where TAttribute : Attribute
        {
            return (TAttribute)(type.GetCustomAttributes(typeof(TAttribute), inherit)).Single();
        }

        #endregion

        [DebuggerStepThroughAttribute]
        public static IEnumerable<PropertyInfo> GetPublicProps<T>(this T obj) where T : class
        {
            return obj.GetType().GetProperties();
        }

        [DebuggerStepThroughAttribute]
        public static PropertyInfo GetPublicProp<T>(this T obj, string name) where T : class
        {
            return obj.GetType().GetProperty(name);
        }
    }
}
