using System;

using Example2_WebServices_AbstractFactory.service;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */

namespace Example2_WebServices_AbstractFactory.impl
{
    public interface IServiceStackAbstractFactory {
        IEmployeeService GetEmployeeService();
        IProductsService GetProductsService();
    }
}






