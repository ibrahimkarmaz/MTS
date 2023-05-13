using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class SupportPeriodMAP:EntityTypeConfiguration<SupportPeriod>
    {
        public SupportPeriodMAP()
        {
            //TABLO ADI
            this.ToTable("SupportPeriods");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.SupportPeriodID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER
            this.Property(x => x.SupportPeriodProgress).HasMaxLength(500);

            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(x => x.SupportPeriodProgress).IsRequired();
            this.Property(x => x.SupportPeriodProgressDate).IsRequired();

            //ALAN ADLARI
            this.Property(x => x.SupportPeriodID).HasColumnName("SupportPeriodID");
            this.Property(x => x.SupportPeriodProgress).HasColumnName("SupportPeriodProgress");
            this.Property(x => x.SupportPeriodProgressDate).HasColumnName("SupportPeriodProgressDate");

            //VERİ TİPİ
            //--
        }
    }
}
