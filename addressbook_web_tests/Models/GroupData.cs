using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Header { get; set; }
        public String Footer { get; set; }
        /*
        public GroupData(String name = "default", String header = "default", String footer = "default")
        {
            Name = name;
            Header = header;
            Footer = footer;
        }*/

        public Boolean Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        public override Int32 GetHashCode()
        {
            return Name.GetHashCode();
        }

        public Int32 CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }
    }
}
