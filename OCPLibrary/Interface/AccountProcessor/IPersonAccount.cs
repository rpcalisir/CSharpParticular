using OCPLibrary.Interface.Model;
using OCPLibrary.Model;

namespace OCPLibrary.Interface.AccountProcessor
{
    public interface IPersonAccount
    {
        Employee CreateAccount(IParticipent person);
    }
}