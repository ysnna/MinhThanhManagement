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

        private List<string> typeStorage;

        private int selectedItemStorage;

        public int SelectedItemStorage
        {
            get { return selectedItemStorage; }
            set { selectedItemStorage = value; }
        }


        public List<string> TypeStorage
        {
            get { return typeStorage; }
            set { typeStorage = value; }
        }

        private bool isEnableEditBtn = false;

        public bool IsEnableEditBtn
        {
            get { return isEnableEditBtn = false; }
            set { isEnableEditBtn = value; }
        }

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
            //GetTypeStorage(ListStorage);
            SelectedItemStorage = -1;
            commonMethod.ReadFileCsv();

        }

        //private void GetTypeStorage(List<StorageModel> list)
        //{
        //    foreach(var item in list)
        //    {
        //        TypeStorage
        //    }
        //}
       
    }
}
