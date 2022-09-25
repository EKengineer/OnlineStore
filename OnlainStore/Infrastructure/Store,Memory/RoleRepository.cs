using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store;

namespace Store_Memory
{
    public class RoleRepository : IRoleRepositoty
    {
        private readonly List<Role> roles = new List<Role>();

        public Role Create(string user)
        {
            var rols = new Role(user);

            roles.Add(rols);

            return rols;
        }
        public List<Role> GetAllRole()
        {
            return roles;
        }
        public Role GetByName(string name)
        {
            return roles.FirstOrDefault(role => role.Name == name);
        }

        public void Remove(string name)
        {
            var role = roles.FirstOrDefault(role => role.Name == name);
            roles.Remove(role);
        }

    }
}
