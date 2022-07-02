using Example2_WebServices_AbstractFactory.impl;
using Example2_WebServices_AbstractFactory.service;


/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace Example2_WebServices_AbstractFactory.ws{
    public class WSServiceStackImpl : IServiceStackAbstractFactory{

       public IEmployeeService GetEmployeeService() {
            return new EmployeeServiceWSImpl();
        }

        public IProductsService GetProductsService() {
            return new ProductServiceWSImpl();
        }
        
    }
}




