using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iwilltry
{
    internal class Store
    {
        public Product[] products = {};
        public Store()
        {
            
        }
        public void AddProduct()
        { 
            Array.Resize(ref products, products.Length-1);
            products[products.Length-1]=products[0];
        }
        public void RemoveProductByNo(double No)
        {

        }
        public void GetProduct()
        {
            if (products == null)
            {
                Console.WriteLine("mehsulu daxil et");
            }

        }
        public void FilterProductsByType(string type)
        {
            for (int i = 0; i < type.Length; i++)
            {
                Console.WriteLine(type[i]);
           
            }

        }
        public void FilterProductByName()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);


            }


        }
    }
}
