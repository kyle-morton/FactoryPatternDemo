using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Factory.Complex.Factories;
using Factory.Shared.Phones;

namespace Factory.Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt();

            IPhoneFactory factory = LoadFactory();

            ICellPhone phone = factory.CreatePhone();
            phone.CallSomeone();

            Terminate();
        }

        static IPhoneFactory LoadFactory()
        {
            //Factory.Complex.Factories.AndroidFactory
            //Factory.Complex.Factories.AppleIphoneFactory


            //get fully qualified name of factory to instantiate
            string factoryName = Properties.Settings.Default.PhoneFactory;

            //use reflection to create a factory instance based on the FQN
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IPhoneFactory;
        }

        #region PROMPTS

        private static char Prompt()
        {
            Console.WriteLine();
            Console.WriteLine("Cell Phone Factory: " + Properties.Settings.Default.PhoneFactory);
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

    }
}
