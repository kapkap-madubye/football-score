using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    public class DataLayerClass
    {
        string path = "./Matches.csv";
        public void SaveResultsToCSV(string results)
        {
            File.AppendAllText(path,results);
        }

        public List<string> GetResultsFromCSV()
        {
            List<string> resultsToBL = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    resultsToBL.Add(line);
                }
            }

            return resultsToBL;
        }
    }
}
