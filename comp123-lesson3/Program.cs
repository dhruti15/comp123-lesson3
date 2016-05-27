using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson3
{
  public class Program
    {
        /**
        *the main method for our driver class program
        *
        *@method Main
        *@param {string[]} args 
        */
       public static void Main(string[] args)
        {
            // create a new instance of the person class
            person person = new person("DHRUTI");
            Console.WriteLine(person.Name);

            //set a value in the name property of the person class
            person.Name = "Dhruti";

            //get the name value and print the result to console
            Console.WriteLine(person.Name);
            

        }
        
    }
}
