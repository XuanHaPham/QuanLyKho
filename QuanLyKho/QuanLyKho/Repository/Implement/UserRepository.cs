using QuanLyKho.Model;
using QuanLyKho.Repository.Interface;
using QuanLyKho.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Repository.Implement
{
    public class UserRepository : IUserRepository
    {

        public bool checkLogin(string username, string password)
        {
            var account = DataProvider.ins.DB.Users.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();
            if (account == null)
                return false;
            return true;
        }
    }
}
