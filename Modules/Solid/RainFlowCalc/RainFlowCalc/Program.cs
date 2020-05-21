using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RainFlowCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //double d = 2;
            //string s = "2";

            //double sToDouble = Convert.ToDouble(s);
            //Console.WriteLine(sToDouble);

            string path = @"E:\CSharp\ProjectAPP\Unnecesary files\Tables\Table_gamma.txt";
            Parser parser = new Parser();
            Dictionary<string, double> testDict = new Dictionary<string, double>();
            parser.parseCSV(path, testDict);

            foreach (KeyValuePair<string, double> keyValuePair in testDict)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
            Console.ReadKey();
        }
    }
}
