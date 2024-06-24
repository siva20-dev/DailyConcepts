using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts
{
    public class StudentComparer : IEqualityComparer<Students>
    {
        public bool Equals(Students x, Students y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Students obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode + nameHashCode;
        }
    }
}
