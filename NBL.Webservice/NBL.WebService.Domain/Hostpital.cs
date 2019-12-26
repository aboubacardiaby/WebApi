using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.WebService.Domain
{
    public class Hostpital:BaseEntity
    {
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Address1 { get; set; }
    }
    
}
