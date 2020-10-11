using System;
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

            ISortMaker sortMaker = GetSorterMaker(method);
            ISorter sorter = sortMaker.MakeSorter();

            ListReader listReader = new ListReader();
            List<int> data = listReader.Read(inPath);

            sorter.Sort(data);

            ListWriter listWriter = new ListWriter();
            listWriter.Write(data, method, outPath);
        }


        static ISortMaker GetSorterMaker(string method)
        {
            switch(method)
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
