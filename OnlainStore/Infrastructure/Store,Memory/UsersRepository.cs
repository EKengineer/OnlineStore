//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Store_Memory;
//using Store_Memory.models;

//namespace Store_Memory
//{
//    public class UsersRepository : IUsersRepository
//    {
//        private readonly IdentityContext identityContext;

//        public UsersRepository(IdentityContext identityContext)
//        {
//            this.identityContext = identityContext;
//        }

//        private readonly List<User> users = new List<User>();

//        public void ChangePassword(string Email, string newPassword)
//        {
//            var account = GetByEmail(Email);
//            account.Password = newPassword;
//        }

//        public User Create(string email, string password)
//        {
//            var user = new User(email, password);

//            users.Add(user);

//            return user;
//        }
//        public List<User> GetAllUsers()
//        {
//            return users;
//        }
//        public User GetByEmail(string email)
//        {
//            return users.FirstOrDefault(user => user.Email == email);
//        }

//        public User GetById(int id)
//        {
//            return users.Single(user => user.Id == id);
//        }

//        public void Remove(string name)
//        {
//            var user = users.FirstOrDefault(user => user.Name == name);
//            users.Remove(user);
//        }

//        public void EditUser(int id, string Email, string Phone, string Name, string Address)
//        {
//            var user = GetById(id);
//            user.Email = Email;
//            user.Address = Address;
//            user.Phone = Phone;
//            user.Name = Name;
//        }

//    }
//}
