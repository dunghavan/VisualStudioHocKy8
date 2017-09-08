using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        private int _id;

        private string _name;

        private string _description;

        private decimal _price;

        private System.Nullable<int> _unitInStock;

        private System.Nullable<int> _catID;
    }
}