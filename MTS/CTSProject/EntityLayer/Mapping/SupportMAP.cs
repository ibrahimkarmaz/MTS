using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class SupportMAP:EntityTypeConfiguration<Support>
    {
        public SupportMAP()
        {
            //TABLO ADI
            this.ToTable("Supports");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.SupportID);

            //BENZERSİZ ALANLAR
           //--

            //EN FAZLA KARAKTER
            this.Property(x => x.SupportTitle).HasMaxLength(50);
            this.Property(x => x.SupportContent).HasMaxLength(200);

            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(x => x.SupportID).IsRequired();
            this.Property(x => x.SupportTitle).IsRequired();
            this.Property(x => x.SupportContent).IsRequired();
            this.Property(x => x.SupportOpenDate).IsRequired();
            this.Property(x => x.SupportCloseDate).IsRequired();
            this.Property(x => x.SupportStatus).IsRequired();

            //ALAN ADLARI
            this.Property(x => x.SupportID).HasColumnName("SupportID");
            this.Property(x => x.SupportTitle).HasColumnName("SupportTitle");
            this.Property(x => x.SupportContent).HasColumnName("SupportContent");
            this.Property(x => x.SupportOpenDate).HasColumnName("SupportOpenDate");
            this.Property(x => x.SupportCloseDate).HasColumnName("SupportCloseDate");
            this.Property(x => x.SupportStatus).HasColumnName("SupportStatus");

            //VERİ TİPİ
            //--
        }
    }
}
