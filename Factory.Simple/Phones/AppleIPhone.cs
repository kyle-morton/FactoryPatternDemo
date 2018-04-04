using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Phones
{
    public class AppleIPhone : ICellPhone
    {

        public void CreateVoicemail()
        {
            Console.WriteLine();
            Console.WriteLine("iPhone - Voicemail Box Created!");
        }

        public void RegisterPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("iPhone - Phone Number Registered!");
        }

        public void StartService()
        {
            Console.WriteLine();
            Console.WriteLine($"iPhone - Starting Service");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("Hello Gloria, I'm calling you from my brand-new Apple iPhone.");
        }

    }
}
