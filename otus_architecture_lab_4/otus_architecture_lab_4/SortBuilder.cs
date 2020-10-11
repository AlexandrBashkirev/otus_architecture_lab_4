using System;

namespace otus_architecture_lab_4
{
    class SortBuilder
    {
        public ISortMaker BuildSortMaker(string method)
        {
            switch (method)
            {
                case "merge":
                    return new MergeSorterMaker();
                case "selection":
                    return new SelectionSorterMaker();
                case "insertion":
                    return new InsertionSorterMaker();
                default:
                    throw new Exception("unknown sort method");
            }
        }
    }
}
