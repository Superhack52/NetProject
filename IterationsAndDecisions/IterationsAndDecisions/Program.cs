using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            IfElseExample();
            SwitchExample();
            SwitchOnStringExample();
            SwitchOnEnumExample();
            Console.ReadLine();
        }

        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            Console.WriteLine();
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInt = { 10, 20, 30, 40 };
            foreach (int i in myInt)
                Console.WriteLine(i);
            Console.WriteLine();
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Value in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        static void IfElseExample()
        {
            string stringData = "My textual data";
            if (stringData.Length > 0)
                Console.WriteLine("string is greater then 0 character");
        }
        static void SwitchExample()
        {
            Console.WriteLine("1 [c#], 2 [VB]");
            Console.WriteLine("Please pick you language preference: ");
            string langChoise = Console.ReadLine();
            int n = int.Parse(langChoise);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Goog choise, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }
        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.WriteLine("Please pick you language preference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Goog choise, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }
        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter you favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dolla");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Footbal!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
        }
    }
}
