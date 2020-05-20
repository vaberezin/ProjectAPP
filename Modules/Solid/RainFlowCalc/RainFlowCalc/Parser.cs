using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace RainFlowCalc
{
    public class Parser
    {
        string filePath = @"C:\Users\User\Documents\ProjectAPP\Unnecesary files\Tables\Table_gamma.txt"; //находим путь к файлу через диалоговое окно, например, впоследствии для версии PRO xD
        List<string> keys4Dict = new List<string>();
        List<double> values4Dict = new List<double>();
        internal async void parseCSV(string filePath, Dictionary<string, double> dictionary)
        {

            string path = filePath;
            FileInfo parseFile = new FileInfo(path);
            if (parseFile.Extension == "txt")
            {                
                string keyPattern = @".*[^0123456789;,]";
                string valuePattern = @"\d,\d*";
                List<string> fromFileList = new List<string>();
                try
                {
                   using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line = "";
                    List<string> tempList = new List<string>();
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        tempList.Add(line);
                    }
                    fromFileList = tempList;
                } 
                }
                catch (Exception e)
                {
                    
                    System.Console.WriteLine(e.Message);
                }
                
                foreach (string s in fromFileList)
                {
                    MatchCollection keys = Regex.Matches(s, keyPattern);
                    foreach (Match match in keys)
                    {
                        //System.Console.WriteLine(match.Value);
                        keys4Dict.Add(match.Value.ToString());
                    }
                    MatchCollection values = Regex.Matches(s, valuePattern);
                    foreach (Match match in values)
                    {
                         //System.Console.WriteLine(match.Value);
                         IFormatProvider RUprovider = new NumberFormatInfo {NumberDecimalSeparator = ","};
                         values4Dict.Add(Convert.ToDouble(match.Value.ToString(), RUprovider));
                         
                    }
                }

                for (int i = 0; i < keys4Dict.Count; i++ )
                {
                    dictionary.Add(keys4Dict[i],values4Dict[i]);    
                }

            }
            else 
            {
                System.Console.WriteLine("Метод не сработал.");
            }            
        }          
        
    }
}
