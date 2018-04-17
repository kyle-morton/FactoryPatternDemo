using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Shared.Phones;

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
