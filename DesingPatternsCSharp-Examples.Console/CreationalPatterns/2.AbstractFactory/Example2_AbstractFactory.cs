using Example2_WebServices_AbstractFactory.impl;
using Example2_WebServices_AbstractFactory.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Example2_AbstractFactory
    {
        public void Run()
        {
            IServiceStackAbstractFactory factory = ServiceStackAbstractFactory.CreateServiceFactory();
            IEmployeeService employeeService = factory.GetEmployeeService();
            IProductsService productService = factory.GetProductsService();

            Console.WriteLine("EmployeeService class > " + typeof(IEmployeeService).Name);
            Console.WriteLine("ProductService class  > " + typeof(IProductsService).Name);

            Console.WriteLine("getEmployee > " + string.Join("", employeeService.GetEmployee()));
            Console.WriteLine("getProduct  > " + string.Join("", productService.GetProducts()));
        }
    }
}
