using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Shared.Phones
{
    public interface IAndroid : ICellPhone
    {
        void CreateGmailAccount();
    }
}
