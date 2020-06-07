using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJ3
{
    class FileReaderApp
    {
        static void Main(string[] args)
        {
            FileReaderFacade fac = new FileReaderFacade();
            fac.readFile(args);
        }
    }
}
