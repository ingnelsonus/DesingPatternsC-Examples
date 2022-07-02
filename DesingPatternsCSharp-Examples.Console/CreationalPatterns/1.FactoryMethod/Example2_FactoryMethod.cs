using FactoryMethod.Example2_DBAccess.dao;
using FactoryMethod.Example2_DBAccess.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Example2_FactoryMethod
    {
        public void Run()
        {
            //Creamos los nuevos productos a registrar
            Product productA = new Product(1, "Product A", 100);
            Product productB = new Product(2, "Product B", 100);

            //Creation of the DAO instance  
            ProductDAO productDAO = new ProductDAO();

            //Product persist  
            productDAO.SaveProduct(productA);
            productDAO.SaveProduct(productB);

            //Create the products  
            List<Product> products = productDAO.FindAllProducts();

            Console.WriteLine("Product size ==> " + products.Count);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
