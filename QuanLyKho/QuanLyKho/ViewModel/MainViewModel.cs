using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        #region
        private ObservableCollection<Stock> _StockList;
        public ObservableCollection<Stock> StockList { get => _StockList; set { _StockList = value; OnPropertyChanged(); } }
        private int _TotalCurrentStock;
        public int TotalCurrentStock { get => _TotalCurrentStock; set { _TotalCurrentStock = value; OnPropertyChanged(); } }
        #endregion
        public MainViewModel() {
            LoadCurrentStock();
            UnitWindowCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { UnitWindow uw = new UnitWindow(); uw.ShowDialog();});
            SuplierCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { SuplierWindow sw = new SuplierWindow(); sw.ShowDialog(); });
            CustomerCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { CustomerWindow sw = new CustomerWindow(); sw.ShowDialog(); });
            InputCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { InputWindow sw = new InputWindow(); sw.ShowDialog(); });
            OutputCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { OutputWindow sw = new OutputWindow(); sw.ShowDialog(); });
            ProductCommand = new RelayCommand<System.Object>((p) => { return true; }, (p) => { ProductWindow sw = new ProductWindow(); sw.ShowDialog(); });
        }

        private void LoadCurrentStock()
        {
            StockList = new ObservableCollection<Stock>();
            var objectList = DataProvider.ins.DB.Objects.ToList();
            int i = 1;
            TotalCurrentStock = 0;
            foreach (var o in objectList)
            {
                var inputInfo = DataProvider.ins.DB.InputInfoes.Where(p => p.IdObject == o.Id);
                var outputInfo = DataProvider.ins.DB.OutputInfoes.Where(p => p.IdObject == o.Id);
                int inputSum = 0 , outputSum = 0;
                if(inputInfo != null )
                    inputSum = (int)inputInfo.Sum(p => p.Count);
                if (outputInfo != null)
                    outputSum = (int)outputInfo.Sum(p => p.Count);
                StockList.Add(new Stock { Object = o, Count = (inputSum - outputSum), STT = i}) ;
                TotalCurrentStock += (inputSum - outputSum);
                i++;
            }
        }

    }
}
