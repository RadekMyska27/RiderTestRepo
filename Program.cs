using System;
using System.Collections.Generic;

namespace konstruktorTets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nahodneCisla = new NahodneCisla();
            var data = new Dictionary<LogicSettings, string>();

            data.Add(new LogicSettings
            {
                A = true,
                B = true,
                C = true
            }, "first");

            data.Add(new LogicSettings
            {
                A = false,
                B = true,
                C = false
            }, "second");

            var findByKey = data[new LogicSettings
            {
                A = false,
                B = true,
                C = false,
            }];
            
            Console.WriteLine("dictionary: " + findByKey);

            foreach (var cislo in nahodneCisla.ListCisel)
            {
                Console.WriteLine("konstruktor přebira cislo: " + cislo);
            }
            
            var image = new Image(nahodneCisla);
            Console.WriteLine("Cislo Image: " + image.Cisla);
            
            Console.ReadKey();
        }
        
        public class LogicSettings
        {
            public bool A { get; set; }
            public bool B { get; set; }
            public bool C { get; set; }
            public bool D { get; set; }
        }
    }
}