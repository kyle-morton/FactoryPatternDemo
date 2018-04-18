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
                var isValid = ValidateEntry(key);

                if (!isValid) break;
                
                IPhoneFactory factory = LoadFactory();
                var phone = factory.GetPhone(key);
                phone.CallSomeone();

                Console.ReadLine();
                Console.Clear();
            }

            Terminate();
        }

        #region FACTORY 

        public static IPhoneFactory LoadFactory()
        {
            return new PhoneFactory();
        }

        #endregion

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
        public static bool ValidateEntry(char character)
        {

            switch (character)
            {
                case 'a': //android
                case 'A':
                case 'i': //iphone
                case 'I':
                case 'b': //blackberry
                case 'B':
                    return true;
                default:
                    return false;
            }

        }

        #endregion

    }
}
