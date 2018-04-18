using Factory.Complex.Phones;

namespace Factory.Complex.Factories
{
    public class AndroidFactory : IPhoneFactory
    {
        public ICellPhone CreatePhone()
        {
            IAndroid android = new Android();

            //custom setup for Android
            android.CreateGmailAccount();

            android.RegisterPhoneNumber();
            android.CreateVoicemail();
            android.StartService();
            return android;
        }
    }
}
