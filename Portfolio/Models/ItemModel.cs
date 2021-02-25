using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ItemModel
    {
        public string Id { get; set; }
        public string location { get; set; }
        public string comment { get; set; }
        public ProductModel productType = new ProductModel();
        public int productTypeIndex { get; set; }
        public bool selected { get; set; }

        //public override string ToString()
        //{
        //    return productType.name;
        //}
    }
}
