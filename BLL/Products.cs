using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Products
    {
        public DAL.Models.Products GetProductsByID(int ID)
        {
            DAL.Products products = new DAL.Products();

            return products.GetProductByID(ID); 
        }
        
        public List<DAL.Models.Products> GetProducts()
        {
            DAL.Products products = new DAL.Products();
            return products.GetProducts();
        }

        public override string ToString()
        {
            string value = string.Empty;
            DAL.Products products = new DAL.Products();
            List<DAL.Models.Products> productsList = products.GetProducts();
            foreach(DAL.Models.Products p in productsList)
            {
                value += p.Id + " - " + p.ProductName + " - " + p.Stock + " - " + p.Price + "\n";
            }

            return value;

        }
    }
}
