using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG0DQ7.Model
{
    public class Loader<T>
    {
        public List<T> LoadFromFile(string fileName, Func<string[], T> parseFunc)
        {
            List<T> list = new List<T>();
            using (var fileReader = new StreamReader(fileName))
            {
                while (!fileReader.EndOfStream)
                {
                    list.Add(parseFunc(fileReader.ReadLine().Split(';')));
                }
                fileReader.Close();
            }
            return list;
        }
    }
}
