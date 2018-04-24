namespace Factory.Simple.Phones
{
    public interface ICellPhone
    {
        string Carrier { get; set; }
        void RegisterPhoneNumber();
        void CreateVoicemail();
        void StartService();
        void CallSomeone();
    }
}
