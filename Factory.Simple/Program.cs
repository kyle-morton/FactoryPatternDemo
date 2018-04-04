using Factory.Simple.Factories;
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
                var phoneType = GetPhoneType(key);

                if (phoneType == null)
                    break;

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

            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();

            return key;
        }


        private static PhoneType? GetPhoneType(char character)
        {
            PhoneType? type = null;

            switch(character)
            {
                case 'a':
                    type = PhoneType.Android;
                    break;
                case 'i':
                    type = PhoneType.iPhone;
                    break;
                case 'b':
                    type = PhoneType.Blackberry;
                    break;
                default:
                    break;
            }

            return type;
        }

        private static void Terminate()
        {
            Console.WriteLine();
            Console.WriteLine("Terminating...");
            Console.ReadLine();
        }

    }
}
