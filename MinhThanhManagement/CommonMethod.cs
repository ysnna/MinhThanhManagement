using MinhThanhManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhThanhManagement
{
    public class CommonMethod
    {
        public void ReadFileCsv()
        {

            string path = GlobalDef.CsvPath + "MinhThanhManagement.csv";
            
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                StorageModel storeModel = new StorageModel();
                string[] models = line.Split(',');
                storeModel.Group = (models[0]);
                storeModel.Name = (models[1]);
                storeModel.Remain = (models[2]);
                storeModel.Price =(Convert.ToDouble(models[3].ToString()));
                GlobalDef.ListStorageModel.Add(storeModel);
            }
        }
        public void ConvertToModel()
        {

        }
    }
}
