using System;

namespace Factory.Simple.Phones
{
    public class AppleIPhone : ICellPhone
    {
        public string Carrier { get; set; }
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
            Console.WriteLine($"-> iPhone - Starting Service with: {Carrier}");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> iPhone - Call Connected!");
        }

    }
}
