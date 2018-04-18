using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Complex.Phones;

namespace Factory.Complex.Factories
{
    public class BlackberryFactory : IPhoneFactory
    {
        public ICellPhone CreatePhone()
        {
            ICellPhone phone = new Blackberry();

            phone.RegisterPhoneNumber();
            phone.CreateVoicemail();
            phone.StartService();

            return phone;
        }
    }
}
