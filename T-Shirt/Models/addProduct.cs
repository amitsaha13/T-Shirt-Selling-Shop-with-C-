using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace T_Shirt.Models
{
    public class addProduct
    {
        public string catagory { get; set; }
        public string subcatagory { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public string productdetails { get; set; }
        public string color { get; set; }
        public string quantity { get; set; }
        public string discount { get; set; }
        public string price { get; set; }
    }
}
