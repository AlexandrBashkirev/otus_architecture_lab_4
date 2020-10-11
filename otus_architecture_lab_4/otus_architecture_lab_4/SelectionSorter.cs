using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    public class SelectionSorter : ISorter
    {
        public void Sort<T>(IList<T> m)
        {
            Comparer<T> defComp = Comparer<T>.Default;

            for (int i = 0; i < m.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < m.Count; j++)
                {
                    if (defComp.Compare(m[j], m[min]) == -1)
                    {
                        min = j;
                    }
                }
                T dummy = m[i];
                m[i] = m[min];
                m[min] = dummy;
            }
        }
    }
}
