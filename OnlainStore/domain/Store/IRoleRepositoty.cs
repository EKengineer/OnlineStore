using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IRoleRepositoty
    {
        Role Create(string user);

        Role GetByName(string name);

        void Remove(string name);

        List<Role> GetAllRole();
    }
}
