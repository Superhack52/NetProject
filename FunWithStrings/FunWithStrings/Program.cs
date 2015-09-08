using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            FunWithStringBuilder();
            Console.ReadLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters",firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y? {0}",firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy",""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatentaion: ");
            string s1 = "Programming the ";
            string s2 = "PsyhoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters: \a");
            string strWithtabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithtabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            Console.WriteLine("All finished. \n\n\n\a");
            Console.WriteLine();
            Console.WriteLine(@"c:\MyApp\bin\Debug");
            string myLongString = @"This is a very
                    very
                           very
                                long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Celebus said ""Darrr! Pet-ty sun-set""");
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("***** Fantastic Games *****", 256);
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
    }
}
