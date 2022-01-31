using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class Program
    {
        static void Main(string[] args)         //Main Function
        {
            int[] arr = { 10, 20, 30, 40 };     //Defining integer Array Value in arr variable
            PrintArray.PrintElements(arr);      //Calling static method to display Array element

            double[] arrdouble = { 12.11, 13.12, 14.13, 15.14, 16.15 };     //Defining double arr value in arrdouble variable
            PrintArray.PrintElements(arrdouble);

            char[] arrchar = { 's', 'h', 'w', 'e', 't', 'a' };
            PrintArray.PrintElements(arrchar);

            Console.WriteLine("\nGeneric Method");
            UsingGenericMethod.PrintElements<int>(arr);             //Calling generic method for integer datatype
            UsingGenericMethod.PrintElements<double>(arrdouble);    //for double datatype
            UsingGenericMethod.PrintElements<char>(arrchar);        //for charactor datatype
            Console.ReadLine();
        }
    }
}
