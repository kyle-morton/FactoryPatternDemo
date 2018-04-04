using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Phones
{
    public class Blackberry : ICellPhone
    {
        public void CreateVoicemail()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Voicemail Box Created!");
        }

        public void RegisterPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Phone Number Registered!");
        }

        public void StartService()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Starting Service");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> Hello Aaron, I bought this phone in 2004.");
        }

    }
}
