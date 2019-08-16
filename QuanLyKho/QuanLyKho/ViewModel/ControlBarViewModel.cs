using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class ControlBarViewModel: BaseViewModel
    {
        #region command
        public ICommand closeWindowCommand { get; set; }
        #endregion
        public ControlBarViewModel()
        {
            closeWindowCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {
                getUserParent(p);
                var w = closeWindowCommand as Window;
                if (w != null)
                {
                    w.Close();
                }
            });
            
        }

        private FrameworkElement getUserParent(UserControl p)
        {
            FrameworkElement parent = p;
            while(parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
    }
}
