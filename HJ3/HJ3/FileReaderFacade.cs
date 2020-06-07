using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJ3
{
    class FileReaderFacade
    {
        public FileReaderFacade()
        {
        }

        public void readFile(string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                string path = files[i];

                List<string> lineas = new List<string>();
                lineas = File.ReadAllLines(path).ToList();

                foreach (String linea in lineas)
                {
                    string linea2 = linea.Replace(' ', ',');
                    Console.WriteLine(linea2);
                }
            }
        }
    }
}
