
namespace otus_architecture_lab_4
{
    class SelectionSorterMaker : ISortMaker
    {
        public ISorter MakeSorter()
        {
            return new SelectionSorter();
        }
    }
}
