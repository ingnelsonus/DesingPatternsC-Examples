using proxy.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Example1_AuditService
    {
        public void Run()
        {
            string user = "oblancarte";
            string password = "1234";
            int process = 1;
            IProcessEjecutor processEjecutor = ServiceFactory.CreateProcessEjecutor();
            try
            {
                processEjecutor.EjecuteProcess(process, user, password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
