using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.WhyProperties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be Null or Empty");
            }
            this._name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }

        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }
    }
}
