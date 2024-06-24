﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Structs
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id { get { return this._id; } set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0},Name = {1}",this._id,this._name);
        }

    }
}
