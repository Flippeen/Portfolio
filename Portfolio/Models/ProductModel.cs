using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ProductModel
    {
		public string category { get; set; }
		public string name { get; set; }
		public string image { get; set; }
		public string activation { get; set; }
		public bool selected { get; set; }

        //public override string ToString()
        //{
        //    return name;
        //}
    }
}
