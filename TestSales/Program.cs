using System;

namespace TestSales
{
    class Program
    {
        static void Main(string[] args)
        {

            BLL.Products p = new BLL.Products();

            Console.WriteLine("TestApp");
            Console.WriteLine();

            Console.WriteLine(p.ToString());
            Console.ReadKey();

        }
    }
}
