using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson3
{

    /**
     * This class is the driver class for our program 
     * 
     * @class Program
     */
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
            Person person = new Person("DHRUTI");
            person.Age = 18;
            person._SaysHello();
            person.ShowAge();

            Console.WriteLine();


            Person Jenny = new Person(18);
            Jenny.Name = "Jenny";
            Jenny._SaysHello();
            Jenny.ShowAge();

            Console.WriteLine();

            Person Thomas = new Person("Thomas", 30);
            Thomas._SaysHello();
           Thomas.ShowAge();

            Console.WriteLine();

            Person Aksar = new Person();
            Aksar.Name = "Aksar";
            Aksar.Age = 19;
           Aksar._SaysHello();
            Aksar.ShowAge();

            Console.ReadLine();

          


        }

    }
}
