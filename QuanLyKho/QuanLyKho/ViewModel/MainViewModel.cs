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
    public class MainViewModel : BaseViewModel
    {
        #region command
        public ICommand UnitWindowCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }
        public ICommand ProductCommand { get; set; }
        #endregion
        public MainViewModel() {
            UnitWindowCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { UnitWindow uw = new UnitWindow(); uw.ShowDialog();});
            SuplierCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { SuplierWindow sw = new SuplierWindow(); sw.ShowDialog(); });
            CustomerCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { CustomerWindow sw = new CustomerWindow(); sw.ShowDialog(); });
            InputCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { InputWindow sw = new InputWindow(); sw.ShowDialog(); });
            OutputCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { OutputWindow sw = new OutputWindow(); sw.ShowDialog(); });
            ProductCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { ProductWindow sw = new ProductWindow(); sw.ShowDialog(); });
        }

    }
}
