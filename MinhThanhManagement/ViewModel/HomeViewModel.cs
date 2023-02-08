using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MinhThanhManagement.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        CommonMethod commonMethod = new CommonMethod();
        public HomeViewModel()
        {
            Initialize();
        }
        public void Initialize()
        {
            commonMethod.ReadFileCsv();
        }
    }
}
