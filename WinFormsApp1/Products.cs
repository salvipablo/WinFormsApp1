using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Products
    {
        private static int _id = 0;
        private string _name;
        private string _price;
        private string _description;

        public Products(string name, string price, string description)
        {
            _id++;
            _name = name;
            _price = price;
            _description = description;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Price { get { return _price; } }
        public string Description { get { return _description; } }
    }
}
