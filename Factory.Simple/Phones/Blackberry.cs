using System;

namespace Factory.Simple.Phones
{
    public class Blackberry : ICellPhone
    {
        public string Carrier { get; set; }
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
            Console.WriteLine($"-> Blackberry - Starting Service with: {Carrier}");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Call Connected!");
        }

    }
}
