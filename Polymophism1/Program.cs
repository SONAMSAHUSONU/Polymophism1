using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism1
{

    //polymphism is one of the primary pillars of the object orianted programing language.
    //polymorphism allows us to invoked drived class methode through base class refrence variable.
    
    public  class Customer
    {
        private string CreateCustomer()
        {
            return null;
        }
        protected string CreateCustomer1()
        {
            return null;
        }
    }
    public class Order: Customer
    {
        public string CreateCustomer()
        {
            Customer c = new Customer();
            Order o = new Order();
            
            return null;
        }
    }
}
