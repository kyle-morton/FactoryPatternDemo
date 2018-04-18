using Factory.Complex.Phones;

namespace Factory.Complex.Factories
{
    public interface IPhoneFactory
    {
        ICellPhone CreatePhone();
    }
}
