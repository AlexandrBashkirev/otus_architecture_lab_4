using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    public class MergeSorter : ISorter
    {
        public void Sort<T>(IList<T> l)
        {
            Comparer<T> defComp = Comparer<T>.Default;

            IList<T> result = MergeSort(l, defComp);
            l.Clear();
            l.AddRange(result);
        }


        IList<T> MergeSort<T>(IList<T> l, Comparer<T> defComp)
        {
            if (l.Count == 1)
            {
                return new List<T>(l);
            }

            int middle = l.Count / 2;
            return Merge(MergeSort(l.Take(middle), defComp), MergeSort(l.Skip(middle), defComp), defComp);
        }


        IList<T> Merge<T>(IList<T> l1, IList<T> l2, Comparer<T> defComp)
        {
            int ptr1 = 0, ptr2 = 0;
            int resultLength = l1.Count + l2.Count;
            List<T> merged = new List<T>();

            for (int i = 0; i < resultLength; ++i)
            {
                if (ptr1 < l1.Count && ptr2 < l2.Count)
                {
                    merged.Add(defComp.Compare(l1[ptr1], l2[ptr2]) == 1 ? l2[ptr2++] : l1[ptr1++]);

                }
                else
                {
                    merged.Add(ptr2 < l2.Count ? l2[ptr2++] : l1[ptr1++]);
                }
            }

            return merged;
        }
    }
}
