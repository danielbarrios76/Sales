using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Products
    {
        
        public List<Models.Products> GetProducts()
        {
            List<Models.Products> productsList = null;
            using (var context = new Models.SalesDBContext())
            {
                productsList = context.Products.OrderBy(x => x.ProductName).ToList();
            }
            return productsList;
            
        }

        public Models.Products GetProductByID(int ID)
        {
            Models.Products product = null;
            using (var context = new Models.SalesDBContext())
            {
                product = context.Products.FirstOrDefault(x => x.Id == ID);
            }
            return product;
                
        }
    }
}
