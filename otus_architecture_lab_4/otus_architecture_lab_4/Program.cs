using System.Collections.Generic;


namespace otus_architecture_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CmdParser cmds = new CmdParser().Init(args);

            string inPath = cmds.GetValue("-ip");
            string outPath = cmds.GetValue("-op");
            string method = cmds.GetValue("-m");

            ISorter sorter = new SortBuilder().BuildSortMaker(method).MakeSorter();

            ListReader listReader = new ListReader();
            List<int> data = listReader.Read(inPath);

            sorter.Sort(data);

            ListWriter listWriter = new ListWriter();
            listWriter.Write(data, method, outPath);
        }
    }
}
