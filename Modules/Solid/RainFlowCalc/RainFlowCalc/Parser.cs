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
        static object locker = new object();
        List<string> keys4Dict = new List<string>();
        List<double> values4Dict = new List<double>();
        public void parseCSV(string filePath, Dictionary<string, double> dictionary)
        {            
            string path = filePath;
            FileInfo parseFile = new FileInfo(path);
            if (parseFile.Extension == ".txt")
            {                
                string keyPattern = @".*[^0123456789;,]";
                string valuePattern = @"[0-9]+(,[0-9][0-9][0-9]?)?\Z";                                                  
                    
                    List<string> fromFileList = new List<string>();
                try
                {
                   using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {
                    System.Console.WriteLine("StreamReader запущен.");
                    string line = "";
                    List<string> tempList = new List<string>();                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        tempList.Add(line);
                    }
                    System.Console.WriteLine("Запись списка из файла окончена.");
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
                        keys4Dict.Add(match.Value.ToString());
                    }
                    MatchCollection values = Regex.Matches(s, valuePattern);
                    foreach (Match match in values)
                    {                         
                         values4Dict.Add(Convert.ToDouble(match.Value.ToString()));                         
                    }
                    foreach (double d in values4Dict)
                        {
                            Console.WriteLine(d);
                        }    
                }
                System.Console.WriteLine("Количество записей в списке полученном из файла -" + fromFileList.Count);
                System.Console.WriteLine("Количество записей в keys4Dict -" + keys4Dict.Count);
                System.Console.WriteLine("Количество записей в values4Dict -" + values4Dict.Count);

                for (int i = 0; i < keys4Dict.Count; i++ ) //при условии что количество ключей равно колическтву значений

                {
                    dictionary.Add(keys4Dict[i],values4Dict[i]);    
                }
                System.Console.WriteLine($"Запись значений в словарь завершена.");

            }
            else 
            {
                System.Console.WriteLine("Метод не сработал.");
            }          
                        
        }          
        
    }
        
    
}
