using Factory.Simple.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple.Extensions
{
    public static class PhoneExtensions
    {

        /// <summary>
        /// return phone type depending on key entered
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static PhoneType? ToPhoneType(this char character)
        {
            PhoneType? type = null;

            switch (character)
            {
                case 'a':
                    type = PhoneType.Android;
                    break;
                case 'i':
                    type = PhoneType.iPhone;
                    break;
                case 'b':
                    type = PhoneType.Blackberry;
                    break;
                default:
                    break;
            }

            return type;
        }

    }
}
