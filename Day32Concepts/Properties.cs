using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
        public int MyProperty { get; set; }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Null or Empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
    }

    public class AutoImplementedProperties
    {
        public string Gender { get; set; }
        public string Password { get; set; }
        public bool isValid { get; set; }
        public DateTime DateTime { get; set; }
        public float Number {  get; set; }
        
        public string Email
        {
            set
            {
                this.Email = value;
            }

            get
            {
                return this.Email;
            }
        }

        public string City
        {
            set
            {
                this.City = value;
            }

            get
            {
                return this.City;
            }
        }
    }
}
