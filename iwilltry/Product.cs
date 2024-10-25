using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iwilltry
{
    internal class Product
    {
        public double No;
        public string Name;
        public double Price;

        public Product(double no, string name, double price)
        {
            No = no;
            Name = name;
            Price = price;

        }
        private double price
        {
            get
            {
                return price;
            }
            set
            {

                if (price < 0)
                {
                    throw new ArgumentException("PriceMustBeGratherThanZeroException");
                }
                else
                {
                    price = value;

                }
            }






        }
    }
}
