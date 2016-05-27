using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson3
{
    /*this class defines a generic person
    *
    *@class person
    *@field _name {string}
    *
    */
    public class Person
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++++
       private string _name;
        private int _age;
        //public properties ++++++++++++++++++++++++++++++++++++++++

            /*<summary>
            *this is a property for our private _name field
            *</summary>
            *@property {string} Name
            */
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                
                this._name = value;
            }

        }
        //
        /**
        *<summary>
        *this is a public property for our private  _age field
        </summary>
        *@property {int} age
        */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        //Constructors +++++++++++++++++++++++++++++++++++++
        /**
        *<summary>
        *this is the default empty constructer for the person class
        *</summary>
        *@constructor person
        */

        public Person()
        {
            
            this.Name ="unknown name!";
            this.Age = 18;
        }
        /**
        *<summary>
        *this is the  constructer that takes name asc a parameter and passes it to the _name private instace variable
        *</summary>
        *@constructor person
        *@param {string} name
        */

        public Person(string name)
        {
            this.Name = name;

            this.Age = 18;
        }
        /**
        * <summary>
        * This is our constructor that takes age as a parameter and 
        * passes it to the _age private instance variable
        * </summary>
        * 
        * @constructor Person
        * @param {int} Age
        */
        public Person(int age)
        {
            this.Name = "unknown name!";
            this.Age = age;
        }
        /**
         * <summary>
         * This is a constructor that takes both name and age as a parameters
         * it assigns the local name value to the name property
         * it assigns the local age value to the age property
         * </summary>
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //Public Methods +++++++++++++++++++++++++++++++++
        /*
        *<summary>
        *this method outputs the _name value with" says hello!" to the console.
        *</summary>
        *@method _sayHello
        *@returns {void}
        */
      public void _SaysHello()
        {
            Console.WriteLine(this.Name + " says hello");
        }
        /**
        * <summary>
        * This method out puts the _age and _name value in the 
        * following format this.Name + " is " + this.Age + " years old "
        * </summary>
        */
        public void ShowAge()
        {
            Console.WriteLine(this.Name +" is " + this.Age + " years old ");
        }
    }
}
