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
            //Создание парсерa для каждого из файлов (всего словарей = количество объе- можно сделать чтобы каждый словарь создавался с названием как у файла и их количество было ) 
            Parser parser1 = new Parser();
            Parser parser2 = new Parser();
            Parser parser3 = new Parser();
            Parser parser4 = new Parser();
            //заполняем каждый словарь (они нужны для последующего вычисления переменных)          

            parser1.parseCSV(path_n_PLess1, Dictionaries.n_PLess1);
            parser2.parseCSV(path_n_PAbove1, Dictionaries.n_PAbove1);
            parser3.parseCSV(path_m_r, Dictionaries.m_r);
            parser4.parseCSV(path_gamma, Dictionaries.gamma);

            
            
            
            

            //System.Console.WriteLine("Словарь Р меньше 1");
            //foreach (KeyValuePair<string, double> keyValuePair in Dictionaries.n_PLess1)
            //{
            //    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            //}
            //System.Console.WriteLine("Словарь Р больше 1");
            //foreach (KeyValuePair<string, double> keyValuePair in Dictionaries.n_PAbove1)
            //{
            //    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            //}
            //System.Console.WriteLine("Словарь m_r");
            //foreach (KeyValuePair<string, double> keyValuePair in Dictionaries.m_r)
            //{
            //    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            //}
            //System.Console.WriteLine("Словарь gamma");
            //foreach (KeyValuePair<string, double> keyValuePair in Dictionaries.gamma)
            //{
            //    Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            //}



            Console.ReadKey();
        }
    }
}
