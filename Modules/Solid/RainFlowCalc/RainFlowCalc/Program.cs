using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RainFlowCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация словарей (пока нет базы, потом) в память программы из файлов *.txt 
            //Пути к файлам с таблицами (сделаны из *.csv)
            string path_n_PLess1 = @"..\Resources\DataTables\Table_n_PLess1.txt";
            string path_n_PAbove1 = @"..\Resources\DataTables\Table_n_PAbove1.txt";
            string path_m_r = @"..\Resources\DataTables\Table_m_r.txt";
            string path_gamma = @"..\Resources\DataTables\Table_gamma.txt";
            //Создание парсеров для каждого из файлов (всего словарей = количество объе- можно сделать чтобы каждый словарь создавался с названием как у файла и их количество было ) 
            Parser.parseCSV(path_n_PLess1, Dictionaries.n_PLess1);
            Parser.parseCSV(path_n_PAbove1, Dictionaries.n_PAbove1);
            Parser.parseCSV(path_m_r, Dictionaries.m_r);
            Parser.parseCSV(path_gamma, Dictionaries.gamma);
            //Dictionary<string, double> testDict = new Dictionary<string, double>();
            

            foreach (KeyValuePair<string, double> keyValuePair in Dictionaries.n_PLess1)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
            Console.ReadKey();
        }
    }
}
