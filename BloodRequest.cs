using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BBMS
{
    public class BloodRequest
    {
        public BloodRequest(User u)
        {

            FromUser = u;

        }
        public BloodRequest()
        {

            FromUser = null;

        }
        public int RequestId { get; set; }

        // Link to user
        public User FromUser { get; set; }

     
        public DateTime RequestDate { get; set; }
        public DateTime NeedDate { get; set; }
        public int UnitsRequested { get; set; }
        public int UnitsAssigned { get; set; }

        public string Condition { get; set; }
        public string Status { get; set; }
        public string BloodGroup { get; set; }
    }
}
