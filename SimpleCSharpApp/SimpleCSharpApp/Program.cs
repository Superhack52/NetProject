using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Вывести пользователю простое сообщение
            Console.WriteLine("***** My Firsrt C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            //Ожидания нажатия кнопки Enter
            Console.ReadLine();

            // Обрабатываем любые входные аргументы
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);
            Console.ReadLine();

            // Обработать любые входящие аргументы с помощью foreach
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}",arg);
            Console.WriteLine();

            // Получить аргументы с использованием System.Environment
            String[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}",arg);
            Console.ReadLine();
            //Возращает произвольный код ошибки
            return -1;
        }
    }
}
