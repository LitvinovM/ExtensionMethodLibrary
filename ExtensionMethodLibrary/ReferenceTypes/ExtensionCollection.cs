using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ExtensionMethodLibrary.Object;

namespace ExtensionMethodLibrary.Collection
{
    public static class ExtensionCollection
    {
        [DebuggerStepThrough]
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            keySelector.ThrowExceptionIfNull();

            var seenKeys = new HashSet<TKey>();
            return source.Where(element => seenKeys.Add(keySelector(element)));
        }

        [DebuggerStepThroughAttribute]
        public static T FirstOrCustom<T>(this IEnumerable<T> source, Func<T, bool> predicate, T value)
        {
            predicate.ThrowExceptionIfNull();

            var enumerable = source as IList<T> ?? source.ToList();
            return enumerable.Where(predicate).Any() ? enumerable.First(predicate) : value;
        }

        [DebuggerStepThroughAttribute]
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> predicate)
        {
            predicate.ThrowExceptionIfNull();

            var forEach = source as IList<T> ?? source.ToList();
            foreach (var type in forEach)
            {
                predicate(type);
            }
            return forEach;
        }

        [DebuggerStepThroughAttribute]
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            var random = new Random();
            return source.OrderBy(x => random.Next());
        }
    }
}
