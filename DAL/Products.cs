using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Products
    {
        private readonly DbContextOptions _options;

        public Products()
        {
            _options = new DbContextOptionsBuilder()
                .UseSqlServer("Server=.\\SQLEXPRESS;Database=SalesDB;User ID=sa;Password=1234")
                .Options;
            
        }

        public List<Entities.Products> GetProducts()
        {
            List<Entities.Products> productsList = null;


            using (var context = new Models.SalesDBContext(_options))
            {
                productsList = context.Products.OrderBy(x => x.ProductName).ToList();
            }
            return productsList;
            
        }

        public Entities.Products GetProductByID(int ID)
        {
            Entities.Products product = null;

            using (var context = new Models.SalesDBContext(_options))
            {
                product = context.Products.FirstOrDefault(x => x.Id == ID);
            }
            return product;
                
        }
    }
}
