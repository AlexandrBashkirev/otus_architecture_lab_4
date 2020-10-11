using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    static class ListExtensionы
    {
        public static List<T> Take<T>(this IList<T> l, int i)
        {
            List<T> result = new List<T>();

            for(int j = 0; j < i; j++)
            {
                result.Add(l[j]);
            }

            return result;
        }


        public static List<T> Skip<T>(this IList<T> l, int i)
        {
            List<T> result = new List<T>();

            for (int j = i; j < l.Count; j++)
            {
                result.Add(l[j]);
            }

            return result;
        }


        public static void AddRange<T>(this IList<T> l, IList<T> l2)
        {
            for (int j = 0; j < l2.Count; j++)
            {
                l.Add(l2[j]);
            }
        }
    }
}
