using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData
    {
        public String Name { get; set; }
        public String Header { get; set; }
        public String Footer { get; set; }

        public GroupData(String name, String header, String footer)
        {
            Name = name;
            Header = header;
            Footer = footer;
        }
    }
}
