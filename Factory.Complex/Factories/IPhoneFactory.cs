using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Shared.Phones;

namespace Factory.Complex.Factories
{
    public interface IPhoneFactory
    {
        ICellPhone CreatePhone();
    }
}
