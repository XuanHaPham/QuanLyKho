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
        #endregion
        public LoginViewModel()
        {
            LoginIcommand = new RelayCommand<FrameworkElement>((p) => { return true; }, (p) => { login(p); });
        }
        private void login(FrameworkElement p)
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
    }
   
}
