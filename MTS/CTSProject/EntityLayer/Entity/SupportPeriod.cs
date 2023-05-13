using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class SupportPeriod
    {
        public int SupportPeriodID { get; set; }
        public string SupportPeriodProgress { get; set; }
        public DateTime? SupportPeriodProgressDate { get; set; }
    }
}
