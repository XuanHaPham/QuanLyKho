using QuanLyKho.Repository.Implement;
using QuanLyKho.Service.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region
        public ICommand LoginIcommand { get; set; }
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        private UserRepository userRepo = new UserRepository();
        #endregion

        public LoginViewModel()
        {
            LoginIcommand = new RelayCommand<FrameworkElement>((p) => { return true; }, (p) => { login(p); });
        }
        private void login(FrameworkElement p)
        {
            bool checkLogin = userRepo.checkLogin(UserName, Password);
            if (checkLogin)
            {
                while (p.Parent != null)
                {
                    p = p.Parent as FrameworkElement;
                }
                MainWindow uw = new MainWindow();
                uw.Show();
                Window w = p as Window;
                w.Close();
            }
            else
            {
                MessageBox.Show("Sai Tên đằng nhập hoặc mật khẩu!");
            }
            
           
        }
    }
   
}
