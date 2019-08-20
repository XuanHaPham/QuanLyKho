using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Repository.Interface
{
    public interface IUserRepository
    {
        bool checkLogin(String username, String password);
    }
}
