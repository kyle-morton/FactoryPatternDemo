using Factory.Simple.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Factories
{
    public class PhoneFactory
    {

        /// <summary>
        /// returns a ready-to-use phone object
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
                    phone = new Android();
                    break;
                case PhoneType.iPhone:
                    phone = new AppleIPhone();
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

    public enum PhoneType
    {
        iPhone,
        Android,
        Blackberry
    }
}
