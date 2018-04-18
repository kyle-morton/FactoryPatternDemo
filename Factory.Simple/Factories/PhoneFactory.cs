using Factory.Simple.Phones;
using System;

namespace Factory.Simple.Factories
{
    /// <summary>
    /// create phone objects
    /// </summary>
    public class PhoneFactory : IPhoneFactory
    {

        /// <summary>
        /// returns a ready-to-use phone
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICellPhone GetPhone(char type)
        {
            ICellPhone phone;

            //create instance of phone 
            switch(type)
            {
                case 'a':
                case 'A':
                    phone = new Android();
                    break;
                case 'i':
                case 'I':
                    phone = new AppleIPhone();
                    break;
                case 'b':
                case 'B':
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
