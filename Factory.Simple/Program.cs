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
                Console.WriteLine();
                Console.WriteLine("Enter a cell phone type (a - android, i - iphone, b - blackberry, anything else - quit):" );
                var key = Console.ReadKey().KeyChar;

                var phoneType = GetPhoneType(key);
                if (phoneType != null) {

                    var phone = new PhoneFactory().GetPhone(phoneType.Value);
                    phone.CallSomeone();

                }
                else
                    break;

                Console.ReadLine();
            }

            Console.WriteLine("Terminating...");
            Console.ReadLine();
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

    }
}
