﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Products
    {
        public Entities.Products GetProductsByID(int ID)
        {
            DAL.Products products = new DAL.Products();

            return products.GetProductByID(ID); 
        }
        
        public List<Entities.Products> GetProducts()
        {
            DAL.Products products = new DAL.Products();
            return products.GetProducts();
        }

        public Entities.Products AddProduct(Entities.Products product)
        {
            DAL.Products products = new DAL.Products();
            products.AddProduct(product);
            return product;
        }

        public Entities.Products RemoveProduct(int ID)
        {
            DAL.Products products = new DAL.Products();
            Entities.Products product;
            product = products.RemoveProduct(ID);
            return product;
        }

        public override string ToString()
        {
            string value = string.Empty;
            DAL.Products products = new DAL.Products();
            List<Entities.Products> productsList = products.GetProducts();
            foreach(Entities.Products p in productsList)
            {
                value += p.Id + " - " + p.ProductName + " - " + p.Stock + " - " + p.Price + "\n";
            }

            return value;

        }
    }
}
