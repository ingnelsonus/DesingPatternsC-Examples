using System;
using Example2_WebServices_AbstractFactory.service;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */

namespace Example2_WebServices_AbstractFactory.rest{
    public class EmployeeServiceRestImpl : IEmployeeService{
        private static readonly string[] EMPLOYEES = new string[]{"Juan","Pedro","Manuel"};

        public string[] GetEmployee() {
            Console.WriteLine("RestFul");
            return EMPLOYEES;
        }
    }
}




