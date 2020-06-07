using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader2
{
    class FileReader
    {
        public FileReader()
        {
        }

        public void formatXML(string[] files)
        {
            for (int i = 0; i < files.Length - 1; i++)
            {

                string path = files[i];
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("<?xml version='1.0' enconding='UTF-16'?>");
                    Console.WriteLine("<project>");
                    Console.WriteLine("<Comment>");
                    Console.WriteLine(line);
                    Console.WriteLine("</Comment>");
                    Console.WriteLine("</project>");
                    Console.WriteLine("</xml");
                    Console.WriteLine("\n");
                }

            }

        }
        
        public void formatCSV(string[] args)
        {


            for (int i = 0; i < args.Length - 1; i++)
            {

                string path = args[i];
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    string line2 = line.Replace(' ', ',');
                    Console.WriteLine(line2);
                    Console.WriteLine("\n");
                }

            }

        }
        

        public void formatHTML(string[] args)
        {

            for (int i = 0; i < args.Length - 1; i++)
            {

                string path = args[i];
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("<html>");
                    Console.WriteLine("<body>");
                    Console.WriteLine("<h1>" + line + "</h1>");
                    Console.WriteLine("</body>");
                    Console.WriteLine("</html>");
                    Console.WriteLine("\n");
                }

            }

        }

        //-------------------------------------------------------------------------------------------------------


        public void formatJSON(string[] args)
        {

            for (int i = 0; i < args.Length - 1; i++)
            {

                string path = args[i];
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (String line in lines)
                {
                    Console.WriteLine("\t[");
                    Console.WriteLine("\t\t{");
                    Console.WriteLine("\t\t\t'" + line + "': \'string\'");
                    Console.WriteLine("\t\t}");
                    Console.WriteLine("\t]");
                    Console.WriteLine("\n");

                }

            }
        }
    }
}
