using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.TypesAndTypeMembersConcept
{
    public class TypesAndTypeMembers
    {
        #region Fields
        private int id;
        private string firstName;
        private string lastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        #endregion
    }
}
