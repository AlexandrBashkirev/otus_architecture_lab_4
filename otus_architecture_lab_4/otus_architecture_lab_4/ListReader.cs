using System;
using System.Collections.Generic;
using System.IO;


namespace otus_architecture_lab_4
{
    class ListReader : IListReader
    {
        public List<int> Read(string path)
        {
            List<int> result = new List<int>();

            using (StreamReader file = File.OpenText(path))
            {
                int value = 0;
                while (Int32.TryParse(file.ReadLine(), out value))
                {
                    result.Add(value);
                }
            }

            return result;
        }
    }
}
