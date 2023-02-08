using MinhThanhManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhThanhManagement
{
    public class GlobalDef
    {
        public static string CsvPath = AppDomain.CurrentDomain.BaseDirectory;
        public static List<StorageModel> ListStorageModel = new List<StorageModel>();

    }
}
