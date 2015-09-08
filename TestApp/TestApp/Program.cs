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
            ShowEnvironmentDetails();
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

        static void ShowEnvironmentDetails()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);// операционная система
            Console.WriteLine("Number of processors: {0}",Environment.ProcessorCount);// количествл процессоров
            Console.WriteLine(".Net version: {0}", Environment.Version);// Версия .Net
        }
    }
}
