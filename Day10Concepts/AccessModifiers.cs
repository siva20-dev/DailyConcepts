using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.AccessModifiers
{
    public class Customer
    {
        private int _id;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }

    #region Protected Access Modifier Example
    public class Customer1
    {
        protected int id;
    }

    public class CorporateCustomer : Customer1
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.id = 101;

        }
    }
    #endregion
}
