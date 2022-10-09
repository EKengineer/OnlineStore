using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory
{
    public interface IUsersRepository
    {
        User Create(string name, string password);

        User GetByEmail(string name);

        void Remove(string name);

        List<User> GetAllUsers();

        void ChangePassword(string userName, string newPassword);

        User GetById(int id);

        void EditUser(int id, string Email, string Phone, string Name, string Address);
    }
}
