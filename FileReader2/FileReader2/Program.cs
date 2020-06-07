using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReaderDecorator frd = new FileReaderDecorator();
            frd.fileFormat(args);
        }
    }
}
