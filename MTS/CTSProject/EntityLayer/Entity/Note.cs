using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Note
    {
        public int NoteID { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public DateTime? NoteReminderTime { get; set; }
        public DateTime? NoteStopDate { get; set; }
        public bool NoteReminderTimeStatus { get; set; }
    }
}
