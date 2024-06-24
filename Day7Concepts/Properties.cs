using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.Properties
{
    #region Properties
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
    #endregion 

    //#region Auto Implemented Properties
    ///// <summary>
    ///// If there is no logic in the property accessors ,then we can make use of auto-implemented properties
    ///// </summary>
    //public class AutoImplementedProperties
    //{
    //    private int _id;
    //    private string _Name;
    //    private int _passMark = 35;
    //    public string email { get;set; }
    //    public string City { get;set; }
    //}
    //#endregion
}
