using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLibary
{
    public class dataOperations
    {
        string path = "./Grades.csv";
        List<string> lstdomains = new List<string>();
        List<string> lstReplacedomains = new List<string>();
        public List<string> ReadFile()
        {
            using (var sr= new StreamReader (path))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    lstdomains.Add(lines);

                }
                return lstdomains;
            }
        }

       public List<string> ReadFileForDomains()
        {
            using (var sr = new StreamReader(path))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    lstReplacedomains.Add(lines);

                }
                return lstReplacedomains;
            }
        }
    }
}
