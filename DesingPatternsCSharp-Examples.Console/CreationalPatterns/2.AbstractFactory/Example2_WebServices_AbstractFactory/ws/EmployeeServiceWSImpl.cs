using Example2_WebServices_AbstractFactory.service;
using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace Example2_WebServices_AbstractFactory.ws{
    public class EmployeeServiceWSImpl : IEmployeeService {

        private static readonly string[] EMPLOYEES = new string[]{"Maria", "Rebeca", "Liliana"};

        public string[] GetEmployee() {
            Console.WriteLine("WebServices");
            return EMPLOYEES;
        }

    }
}





