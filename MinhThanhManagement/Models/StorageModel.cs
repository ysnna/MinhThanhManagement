using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhThanhManagement.Models
{
    public class StorageModel
    {
		private StorageModel() { }
        public static StorageModel _instance = null;

        public static StorageModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StorageModel();
            }
            return _instance;
        }
        private List<string> group = new List<string>();

		public List<string> Group
		{
			get { return group; }
			set { group = value; }
		}

		private List<string> name = new List<string>();

		public List<string> Name
		{
			get { return name; }
			set { name = value; }
		}

		private List<string> remain = new List<string>();

		public List<string> Remain
		{
			get { return remain; }
			set { remain = value; }
		}
		private List<double> price = new List<double>();

        public List<double> Price
		{
			get { return price; }
			set { price = value; }
		}


	}
}
