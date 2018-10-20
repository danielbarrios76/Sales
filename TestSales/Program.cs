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

            //Console.WriteLine("Agregar Nuevo Elemento");
            //Console.WriteLine();

            //p.AddProduct(new Entities.Products {
            //    ProductName = "Harina",
            //    Price = 27.0,
            //    Stock = 40 });

            //Console.WriteLine(p.ToString());

            //Console.WriteLine("Eliminar un elemento");
            //Console.WriteLine();

            p.RemoveProduct(4);

            Console.WriteLine(p.ToString());
            Console.ReadKey();

        }
    }
}
