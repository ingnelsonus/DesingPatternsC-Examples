using Example2_WebServices_AbstractFactory.service;
using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace Example2_WebServices_AbstractFactory.ws{
    public class ProductServiceWSImpl : IProductsService {

        private static readonly string[] PRODUCTS = new string[]{"Soda", "Juice", "Fruit"};

        public string[] GetProducts() {
            Console.WriteLine("WebServices");
            return PRODUCTS;
        }
    }
}




