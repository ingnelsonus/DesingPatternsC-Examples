using facade.util;
using System;
/**
 * @author Oscar Javier Blancarte Iturralde.
 * @see http://oscarblancarteblog.com
 */
namespace facade.subsystems.crm{
    public class CRMSystem {
        
        public Customer FindCustomer(Int64 customerId){
            return OnMemoryDataBase.findCustomerById(customerId);
        }
    }
}


