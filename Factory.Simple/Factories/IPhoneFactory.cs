using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Simple.Phones;

namespace Factory.Simple.Factories
{
    public interface IPhoneFactory
    {
        ICellPhone GetPhone(char type);
    }
}
