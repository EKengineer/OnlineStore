using Store;

namespace Store_Memory
{
    public interface IOrderRepositoty
    {
        Order Add(string name, string phone, string address, Cart cart);

        Order GetByUseID(string userId);

        Order GetByName(string name);

        Order GetByPhone(string phone);
    }
}