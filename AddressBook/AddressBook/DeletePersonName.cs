using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DeletePersonName : BookAddress        //child class
    {
        public DeletePersonName() : base()
        {
            Console.WriteLine("Give person name to delete:");
            string efg = Console.ReadLine();
            Console.WriteLine("Dleting person name");
            if (efg == firstName)
            {
                firstName = " ";
                lastName = " ";
                address = " ";
                city = " ";
                state = " ";
                email = " ";
                contactNumber = 0000000000;
            }
            else
                Console.WriteLine("Name not exist");
        }
    }
}
