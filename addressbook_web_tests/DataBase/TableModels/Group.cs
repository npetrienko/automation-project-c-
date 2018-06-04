using System;

namespace WebAddressbookTests.DataBase.TableModels
{
    public class Group
    {
        public Int32 Domain_id { get; set; }
        public Int32 Group_id { get; set; }
        public Int32 Group_parent_id { get; set; }
        public String Created { get; set; }
        public String Modified { get; set; }
        public String Deprecated { get; set; }
        public String Group_Name { get; set; }
        public String Group_Header { get; set; }
        public String Group_Footer { get; set; }
    }
}
