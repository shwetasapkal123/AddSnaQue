using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    //child class
    class AddContact : BookAddress
    {
        public AddContact(string firstName, string lastName, string address, string city, string state, string email, long contactNumber) : base(firstName, lastName, address, city, state, email, contactNumber)
        {
            Console.WriteLine("Adding Contact to address:\n"+1122334455); //Adding new contact number
            Console.WriteLine("Name:" + firstName + " " + lastName + "\nAddress: " + address + "  " + city + "  " + state  + "\nEmailId:" + email);
        }
    }
}
