using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new DataProvider();
                }
                return _ins;
            }
        }
        public QuanLyKhoEntities1 DB { get; set; }
        private DataProvider()
        {
            DB = new QuanLyKhoEntities1();
        }
    }
}
