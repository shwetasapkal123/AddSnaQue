using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
     class BookAddress      //Parent class
    {//Instance Variable
        public string firstName, lastName, address, city, state, email;
        public long contactNumber;

        //constructor
        public BookAddress(string firstName,string lastName,string address,string city,string state,string email,long contactNumber)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email=email;
            this.contactNumber = contactNumber;
        }

        public BookAddress()        //constructor for Delete person name polymorphism
        {
        }

        public void Display()       //function for displaying data
        {
            Console.WriteLine("Address Book of:"+firstName);
            Console.WriteLine("Name:"+firstName+" " + lastName+"\nAddress: "+ address+"  " + city+"  " +state+"\n" +contactNumber+"\nEmailId:"+ email);
        }

        static void Main(string[] args)
        {
            //UC1:Creating Address Book
            BookAddress shweta = new BookAddress("Shweta", "Sapkal", "Chinchner Vandan","Satara","Maharashtra","shwetasapkal199@gmail.com",1234567890);
            shweta.Display();
            BookAddress shubhangi = new BookAddress("Shubhangi","Dingane","Golibar Maidan","Satara","Maharashtra","shubhangidingane96@gmail.com",9987654321);
            shubhangi.Display();

            //uc2 new contact adding to address book
            AddContact abc = new AddContact("Shweta", "Sapkal", "Chinchner Vandan", "Satara", "Maharashtra", "shwetasapkal199@gmail.com", 1234567890);

            //uc4
            DeletePersonName sdg = new DeletePersonName();
            Console.ReadLine();
        }
    }
}
