
namespace otus_architecture_lab_4
{
    class MergeSorterMaker : ISortMaker
    {
        public ISorter MakeSorter()
        {
            return new MergeSorter();
        }
    }
}
