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
    public class person
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++++
       private string _name;

        //public properties ++++++++++++++++++++++++++++++++++++++++

            /*
            *this is a property for our _name field
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
        /**
        *this is the default empty constructer for the person class
        *
        *@constructor person
        */

        public person()
        {
            this._name ="unknown name!";
        }
        /**
        *this is the  constructer that takes name asc a parameter and passes it to the _name private instace variable
        *
        *@constructor person
        *@param {string} name
        */

        public person(string name)
        {
            this._name = name;
        }
    }
}
