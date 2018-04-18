using Factory.Complex.Phones;

namespace Factory.Complex.Factories
{
    public class AppleIphoneFactory : IPhoneFactory
    {
        public ICellPhone CreatePhone()
        {
            IAppleIPhone phone = new AppleIPhone();

            //custom setup for Apple iPhone
            phone.CreateICloudAccount();

            phone.RegisterPhoneNumber();
            phone.CreateVoicemail();
            phone.StartService();
            return phone;
        }
    }
}
