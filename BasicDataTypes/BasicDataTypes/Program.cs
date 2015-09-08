using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.AccessControl;

namespace BasicDataTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LocalVarDeclaration();
            ObjecFunctionality();
            DataTypeFunctionality();
            Console.WriteLine();
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
            CharFunctionality();
            ParseFromString();
            UseDatesAndTimes();
            UseBigInteger();
            Console.ReadLine();
        }

        private static void LocalVarDeclaration()
        {
            Console.WriteLine("=> Data Declaratiopns:");
            int myInt = 0;
            string myString;
            myString = "This is my character data";
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine("You data: {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void ObjecFunctionality()
        {
            Console.WriteLine("=> System.Object Funcitonality: ");
            Console.WriteLine("12.GetHashCode() = {0}",12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}",12.Equals(23));
            Console.WriteLine("12.ToString() = {0}",12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Date type Functionality: ");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> Char Functionality: ");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter(myChar): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There',5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsPuIsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing: ");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times: ");
            DateTime dt = new DateTime(2011, 10, 17);
            Console.WriteLine("The day of {0} is {1}", dt.Date,dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BugInteger: ");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("biggy.IsEven {0}",biggy.IsEven);//biggy четное?
            Console.WriteLine("biggy.IsPowerOfTwo: {0}",biggy.IsPowerOfTwo);// biggy степень 2?
            BigInteger realyBig = BigInteger.Multiply(biggy,BigInteger.Parse("888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}",realyBig);
        }
    }
}
