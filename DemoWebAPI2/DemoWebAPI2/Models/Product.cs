using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI2.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int unitInStock { get; set; }
        public int catID { get; set; }
    }
}