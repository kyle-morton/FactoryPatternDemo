using Factory.Simple.Phones;
using System;

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

}
