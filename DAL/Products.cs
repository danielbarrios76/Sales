using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Products : BaseDAL
    {
 
        public List<Entities.Products> GetProducts()
        {
            List<Entities.Products> productsList = null;


            using (var context = new Models.SalesDBContext(Options))
            {
                productsList = context.Products.OrderBy(x => x.ProductName).ToList();
            }
            return productsList;
            
        }

        public Entities.Products GetProductByID(int ID)
        {
            Entities.Products product = null;

            using (var context = new Models.SalesDBContext(Options))
            {
                product = context.Products.FirstOrDefault(x => x.Id == ID);
            }
            return product;
                
        }

        public Entities.Products AddProduct(Entities.Products product)
        {
            using (var context = new Models.SalesDBContext(Options))
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            return product;
        }

        public Entities.Products RemoveProduct(int ID)
        {
            Entities.Products product;

            using (var context = new Models.SalesDBContext(Options))
            {
                product = context.Products.FirstOrDefault(p => p.Id == ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }

            return product;
        }
    }
}
