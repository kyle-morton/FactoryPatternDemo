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
                    phone = new Android { 
                        Carrier = "Verizon"
                    };
                    break;
                case 'i':
                case 'I':
                    phone = new AppleIPhone {
                        Carrier = "AT&T"
                    };
                    break;
                case 'b':
                case 'B':
                    phone = new Blackberry {
                        Carrier = "Sprint"
                    };
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
