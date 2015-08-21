using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureCUI();
            // Ожидать нажатия <Enter>
            Console.ReadLine();
        }

        private static void ConfigureCUI()
        {
            // Настроить консольный интерфейс (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Welcome to My Rocking App ****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
