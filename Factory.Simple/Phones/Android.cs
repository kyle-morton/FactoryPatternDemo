using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Phones
{
    public class Android : ICellPhone
    {

        public void CreateVoicemail()
        {
            Console.WriteLine();
            Console.WriteLine("-> Android - Voicemail Box Created!");
        }

        public void RegisterPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("-> Android - Phone Number Registered!");
        }

        public void StartService()
        {
            Console.WriteLine();
            Console.WriteLine("-> Android - Starting Service");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> Hello Todd, I'm calling you from my brand-new Android phone.");
        }
    }
}
