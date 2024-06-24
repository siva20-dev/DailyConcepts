using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.StructureConcepts
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public int Id
        { 
            get { return this._id; } 
            set { this._id = value; } 
        }

        public Customer(int id,string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id={0} && Name={1}",this._id,this._name);
        }
    }
}
