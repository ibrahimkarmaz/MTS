using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Support
    {
        public int SupportID { get; set; }
        public string SupportTitle { get; set; }
        public string SupportContent { get; set; }
        public DateTime? SupportOpenDate { get; set; }
        public DateTime? SupportCloseDate { get; set; }
        public bool SupportStatus { get; set; }
    }
}
