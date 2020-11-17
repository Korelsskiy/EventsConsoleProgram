using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        public delegate string NameDelegate(); // это делегат, он может вызвать любое количество подписавшихся на него
        // методов, схожих по сигнатуре
        static void Main(string[] args)
        {
           NameDelegate name = GetDeveloperName; // подписались на метод

           Console.WriteLine(name.Invoke()); // вызвали деленат, а он метод
           Console.ReadLine();
        }

        private static string GetDeveloperName()
        {
            return "Кирилл";
        }
    }
}
