using Factory.Shared.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Factories
{
    /// <summary>
    /// create phone objects
    /// </summary>
    public class PhoneFactory
    {

        /// <summary>
        /// returns a ready-to-use phone
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICellPhone GetPhone(PhoneType type)
        {
            ICellPhone phone = null;

            //create instance of phone 
            switch(type)
            {
                case PhoneType.Android:
                    var android = new Android();
                    android.CreateGmailAccount();
                    phone = android;
                    break;
                case PhoneType.iPhone:
                    var iPhone = new AppleIPhone();
                    iPhone.CreateICloudAccount();
                    phone = iPhone;
                    break;
                case PhoneType.Blackberry:
                    phone = new Blackberry();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            //call needed init methods
            phone.RegisterPhoneNumber();
            phone.CreateVoicemail();
            phone.StartService();

            //return initialized phone object (Product)
            return phone;
        }
    }

}
