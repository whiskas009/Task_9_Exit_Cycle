using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Exit_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите слово для выхода");
           string word = Console.ReadLine();

           for (;word != "exit"; word = Console.ReadLine())
            {
                Console.WriteLine("Подумайте ещё");
            }
        }
    }
}
