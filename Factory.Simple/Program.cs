using Factory.Simple.Factories;
using Factory.Simple.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var key = PromptForKey();
                var phoneType = key.ToPhoneType();

                if (phoneType == null) break;

                var phone = new PhoneFactory().GetPhone(phoneType.Value);
                phone.CallSomeone();

                Console.ReadLine();
                Console.Clear();
            }

            Terminate();
        }


        private static char PromptForKey()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a cell phone type:");
            Console.WriteLine("a - android, i - iphone, b - blackberry, anything else - quit");
            Console.WriteLine("-----------------------------------------");
            Console.Write("-> ");

            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();

            return key;
        }

        private static void Terminate()
        {
            Console.WriteLine();
            Console.WriteLine("Terminating...");
            Console.ReadLine();
        }

    }
}
