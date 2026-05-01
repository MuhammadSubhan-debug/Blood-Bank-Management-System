using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BBMS
{
    public class User
    {
        public string Name { get;set;  }
        public int Age { get;set;  }
        public int UserId { get;set;  }
        public string Email { get;set; }
        public string BloodGroup { get;set; }
        public string City { get; set; }
        public string Path { get; set; }
        public string Gender { get; set; }
        public string Cnic { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public DateTime ? LastDonation { get; set; }
        public bool isVerfied { get;set;}
        public override string ToString()
        {
            return Name; // or Name + " (" + BloodGroup + ")"
        }


    }
}
