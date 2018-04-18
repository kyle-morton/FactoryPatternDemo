using Factory.Simple.Factories;
using Factory.Simple.Phones;
using System;

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

                if (phoneType == null) break;

                var phone = new PhoneFactory().GetPhone(phoneType.Value);
                phone.CallSomeone();

                Console.ReadLine();
                Console.Clear();
            }

            Terminate();
        }

        #region PROMPT

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

        #endregion

        #region PROMPT

        /// <summary>
        /// return phone type depending on key entered
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static PhoneType? GetPhoneType(char character)
        {
            PhoneType? type = null;

            switch (character)
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

        #endregion

    }
}
