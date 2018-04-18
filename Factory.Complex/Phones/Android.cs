using System;

namespace Factory.Complex.Phones
{
    public class Android : IAndroid
    {

        public Android()
        {
        }

        public void CreateGmailAccount()
        {
            Console.WriteLine();
            Console.WriteLine("-> Android - Gmail Account Created!");
        }

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
            Console.WriteLine("-> Hey Bill, I'm calling you from my new Android phone.");
        }

    }
}
