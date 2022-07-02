using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2_DBAccess.entity
{
    internal class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(int idProduct, string productName, double price)
        {
            this.IdProduct = idProduct;
            this.ProductName = productName;
            this.Price = price;
        }       

        public string toString()
        {
            return "Product{" + "idProduct=" + IdProduct + ", productName=" + ProductName + ", price=" + Price + '}';
        }
    }
}
