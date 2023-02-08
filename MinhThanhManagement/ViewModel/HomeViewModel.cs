using MinhThanhManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MinhThanhManagement.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        CommonMethod commonMethod = new CommonMethod();
        private List<StorageModel> listStorage = new List<StorageModel>();

        public List<StorageModel> ListStorage
        {
            get { return listStorage; }
            set { listStorage = value; }
        }
        public HomeViewModel()
        {
            Initialize();
        }
        public void Initialize()
        {
            ListStorage = GlobalDef.ListStorageModel;
            commonMethod.ReadFileCsv();

        }
       
    }
}
