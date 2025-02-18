using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool LivesUSA()
        {
            if (_address.IsUSA())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DisplayCustomerName()
        {
            return _name;
        }
        
        public string DisplayCustomerAddress(){
            return _address.DisplayAddress();
        }

    }
}