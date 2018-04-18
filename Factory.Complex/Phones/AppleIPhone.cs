using System;

namespace Factory.Complex.Phones
{
    public class AppleIPhone : IAppleIPhone
    {

        public AppleIPhone()
        {
        }

        public void CreateICloudAccount()
        {
            Console.WriteLine();
            Console.WriteLine("-> iPhone - iCloud Account Created!");
        }

        public void CreateVoicemail()
        {
            Console.WriteLine();
            Console.WriteLine("-> iPhone - Voicemail Box Created!");
        }

        public void RegisterPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("-> iPhone - Phone Number Registered!");
        }

        public void StartService()
        {
            Console.WriteLine();
            Console.WriteLine("-> iPhone - Starting Service");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> Hey Mary, I'm calling you from my new Apple iPhone.");
        }

    }
}
