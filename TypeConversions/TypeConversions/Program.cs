using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            short numb1 = 30000, numb2 = 30000;
            short answer = (short) Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            ProcessBytes();
            DeclareImplicitVars();
            
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                unchecked
                {
                    byte sum = checked((byte) Add(b1, b2));
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            Console.WriteLine("myInt us a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool us a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString us a: {0}", myString.GetType().Name);
        }

        static int GetAnInt()
        {
            var retVal = 9;
            return retVal;
        }
    }
}
