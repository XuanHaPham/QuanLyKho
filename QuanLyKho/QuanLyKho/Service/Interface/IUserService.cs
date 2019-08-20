using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Service.Interface
{
    public interface IUserService
    {
        bool CheckLogin(String username, String password);
    }
}
