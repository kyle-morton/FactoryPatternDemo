namespace Factory.Simple.Phones
{
    public interface ICellPhone
    {
        void RegisterPhoneNumber();
        void CreateVoicemail();
        void StartService();
        void CallSomeone();
    }
}
