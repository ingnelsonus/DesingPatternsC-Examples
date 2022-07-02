using Example2_WebServices_AbstractFactory.service;
using System;


/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */

namespace Example2_WebServices_AbstractFactory.rest
{
    public class ProductServiceRestImpl : IProductsService{
        private static readonly string[] PRODUCTS = new string[]{"keyboard","Mouse","Display"};

        public string[] GetProducts() {
            Console.WriteLine("RestFul");
            return PRODUCTS;
        }
    }
}





