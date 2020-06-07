using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader2
{
    class FileReaderDecorator
    {
        public void fileFormat(string[] args)
        {
            FileReader fr = new FileReader();
            if (args.Contains("XML"))
            {
                fr.formatXML(args);
            }
            else if (args.Contains("CSV"))
            {
                fr.formatCSV(args);
            }
            else if (args.Contains("HTML"))
            {
                fr.formatHTML(args);
            }
            else if (args.Contains("JSON"))
            {
                fr.formatJSON(args);
            }
        }
    }
}