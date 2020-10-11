using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    public interface ISorter
    {
        void Sort<T>(IList<T> l);
    }
}
