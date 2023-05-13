using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class NoteMAP:EntityTypeConfiguration<Note>
    {
        public NoteMAP()
        {
            //TABLO ADI
            this.ToTable("Notes");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.NoteID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER
            this.Property(x => x.NoteTitle).HasMaxLength(50);
            this.Property(x => x.NoteContent).HasMaxLength(500);


            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(x => x.NoteID).IsRequired();
            this.Property(x => x.NoteTitle).IsRequired();
            this.Property(x => x.NoteContent).IsRequired();
            this.Property(x => x.NoteStopDate).IsRequired();
            this.Property(x => x.NoteReminderTimeStatus).IsRequired();

            //ALAN ADLARI
            this.Property(x => x.NoteID).HasColumnName("NoteID");
            this.Property(x => x.NoteTitle).HasColumnName("NoteTitle");
            this.Property(x => x.NoteContent).HasColumnName("NoteContent");
            this.Property(x => x.NoteReminderTime).HasColumnName("NoteReminderTime");
            this.Property(x => x.NoteStopDate).HasColumnName("NoteStopDate");
            this.Property(x => x.NoteReminderTimeStatus).HasColumnName("NoteReminderTimeStatus");

            //VERİ TİPİ
           //--
        }
    }
}
