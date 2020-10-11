using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    public class InsertionSorter : ISorter
    {
        public void Sort<T>(IList<T> l)
        {
            Comparer<T> defComp = Comparer<T>.Default;

            for (int i = 1; i < l.Count; i++)
            {
                T x = l[i];
                int j = i;
                while(j > 0 && defComp.Compare(l[j-1], x) == 1)
                {
                    l[j] = l[j - 1];
                    j--;
                }
                l[j] = x;
            }
        }
    }
}
