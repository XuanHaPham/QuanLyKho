using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class UnitViewModel : BaseViewModel
    {
        #region
        public ICommand AddUnitCommand { get; set; }
        private ObservableCollection<Unit> _UnitList;
        public ObservableCollection<Unit> UnitList { get => _UnitList; set { _UnitList = value; OnPropertyChanged(); } }
        private Unit _SelectedItem;
        public Unit SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); if (SelectedItem != null) DisplayName = SelectedItem.DisplayName; } }
        private String _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        #endregion
        public UnitViewModel()
        {
            UnitList = new ObservableCollection<Unit>(DataProvider.ins.DB.Units);
            AddUnitCommand = new RelayCommand<System.Object>((p) => 
            {
                if (string.IsNullOrEmpty(DisplayName))
                    return false;
                var unit = DataProvider.ins.DB.Units.Where(u => u.DisplayName == DisplayName);
                if (unit != null || unit.Count() > 0)
                    return false;
                return true;
                    }, (p) => {
                        Unit u = new Unit() { DisplayName = DisplayName };
                        DataProvider.ins.DB.Units.Add(u);
                        DataProvider.ins.DB.SaveChanges();
                        UnitList.Add(u);
                    });
        }

    }
}
