using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS
{
    public class DonationAppointment
    {
        public DonationAppointment(User user) { 
        FromUser = user;
        
        }
        public DonationAppointment() { 
        
        
        }
        public int AppointmentId { get; set; }

      
        public User FromUser { get; set; }

      
        public DateTime AppointmentDate { get; set; }
       
        public string AdditionalRemarks { get; set; }
        public string Status { get; set; } 

    }
}
