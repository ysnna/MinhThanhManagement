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
                string[] models = line.Split(',');
                StorageModel.GetInstance().Group.Add(models[0]);
                StorageModel.GetInstance().Name.Add(models[1]);
                StorageModel.GetInstance().Remain.Add(models[2]);
                StorageModel.GetInstance().Price.Add(Convert.ToDouble(models[3].ToString()));
            }
        }
        public void ConvertToModel()
        {

        }
    }
}
