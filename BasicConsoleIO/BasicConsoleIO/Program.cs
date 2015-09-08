using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
            FormatNumericalData();
            Console.ReadLine();
            DisplayMessage();
            Console.ReadLine();
        }

        static void GetUserData()
        {
            //Получить информацию об имени и возрасте пользователя
            Console.Write("Please enter user name: ");
            String userName = Console.ReadLine();
            Console.Write("Please enter you age: ");
            String userAge = Console.ReadLine();

            // Изменить цвет переднего плана
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Вывести полученные сведения на консоль
            Console.WriteLine("Hello {0}! You are {1} years old", userName, userAge);
            Console.ForegroundColor = prevColor;
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 9999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 9999);
            Console.WriteLine("d9 format: {0:d9}", 9999);
            Console.WriteLine("f3 format: {0:f3}", 9999);
            Console.WriteLine("n format: {0:n}", 9999);

            Console.WriteLine("E format: {0:E}", 9999);
            Console.WriteLine("e format: {0:e}", 9999);
            Console.WriteLine("X format: {0:X}", 9999);
            Console.WriteLine("x format: {0:x}", 9999);
        }

        static void DisplayMessage()
        {
            // Использование string.Format() для форматирования строкового литера
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
