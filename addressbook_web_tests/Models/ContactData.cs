using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests

{
    public class ContactData
    {
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String NickName { get; set; }
        //here shiuld be Photo
        public String Title { get; set; }
        public String Company { get; set; }
        public String Address { get; set; }
        public String HomeTelephone { get; set; }
        public String MobileTelephone { get; set; }
        public String WorkTelephone { get; set; }
        public String Fax { get; set; }
        public String Email1 { get; set; }
        public String Email2 { get; set; }
        public String Email3 { get; set; }
        public String HomePage { get; set; }
        //here should be Birthday
        //here should be Anniversary
        //here should be Group
        public String SecondaryAddress { get; set; }
        public String SecondaryHome { get; set; }
        public String SecondaryNotes { get; set; }

        public ContactData(String firstName, String lastName, String nickName, String company, String workTelephone, String email1)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Company = company;
            WorkTelephone = workTelephone;
            Email1 = email1;
        } 
    }
}
