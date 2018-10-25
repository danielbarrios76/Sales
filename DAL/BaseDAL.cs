using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DAL
{
    public class BaseDAL
    {
        protected readonly DbContextOptions Options;
        
        public BaseDAL()
        {
            Options = new DbContextOptionsBuilder()
                .UseSqlServer(GetConnectionString())
                .Options;
           
        }

        public static IConfiguration Configuration { get; set; }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()            
            .SetBasePath("D:\\Projects\\Sales\\DAL")
            .AddJsonFile("config.json");

            Configuration = builder.Build();

            return Configuration.GetConnectionString("SalesDBContext");

        }

    }
}
