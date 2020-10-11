

namespace otus_architecture_lab_4
{
    class InsertionSorterMaker : ISortMaker
    {
        public ISorter MakeSorter()
        {
            return new InsertionSorter();
        }
    }
}
