using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS
{
    public class BloodUnit
    {
        public string BloodGroup { get;set;  }
        public string Status { get; set; }
        public DateTime collectionDate { get;set;  }
        public int BloodUnitId { get; set; }

        public int DonorId { get;set;  }
    }
}
