using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhThanhManagement
{
    public class HomeViewModel : HomeView
    {
        CommonMethod commonMethod = new CommonMethod();
        public HomeViewModel() {
            InitializeComponent();
        }
        public void Initialize()
        {
            commonMethod.ReadFileCsv();
        }
    }
}
