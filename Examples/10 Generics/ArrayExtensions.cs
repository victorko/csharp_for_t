using System;

namespace Examples.Generics
{
    public static class ArrayExtensions
    {
        public static T[] Append<T>(this T[] array, params T[] tail)
        {
            var result = new T[array.Length + tail.Length];
            array.CopyTo(result, 0);
            tail.CopyTo(result, array.Length);
            return result;
        }

        public static T[] Trim<T>(this T[] array, int length)
        {
            if (array.Length >= length)
                return array;

            var result = new T[length];
            Array.Copy(array, result, length);
            return result;
        }

        public delegate bool Predicate<in T>(T item);

        public static T[] FindAll<T>(this T[] array, Predicate<T> cond)
        {
            var result = new T[array.Length];
            var foundCount = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (cond(array[i]))
                {
                    result[foundCount] = array[i];
                    foundCount++;
                }
            }
            return result.Trim(foundCount);
        }

        public static T Min<T>(this T[] array) where T : IComparable<T>
        {
            var result = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(result) < 0)
                    result = array[i];
            }
            return result;
        }
    }
}
