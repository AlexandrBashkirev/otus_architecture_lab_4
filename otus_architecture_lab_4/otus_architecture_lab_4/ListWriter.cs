using System.Collections.Generic;
using System.IO;


namespace otus_architecture_lab_4
{
    class ListWriter : IListWriter
    {
        public void Write(List<int> l, string method, string path)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                file.WriteLine(method);

                foreach(int value in l)
                {
                    file.WriteLine(value.ToString());
                }
            }
        }
    }
}
