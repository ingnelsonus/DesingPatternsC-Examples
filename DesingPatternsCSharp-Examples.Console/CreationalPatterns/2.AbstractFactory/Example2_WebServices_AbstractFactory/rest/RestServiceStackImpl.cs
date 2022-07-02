using Example2_WebServices_AbstractFactory.impl;
using Example2_WebServices_AbstractFactory.service;
using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */

namespace Example2_WebServices_AbstractFactory.rest
{
    public class RestServiceStackImpl : IServiceStackAbstractFactory{
        public IEmployeeService GetEmployeeService() {
            return new EmployeeServiceRestImpl();
        }

        public IProductsService GetProductsService() {
            return new ProductServiceRestImpl();
        }
    }
}




