using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CountyMAP:EntityTypeConfiguration<County>
    {
        public CountyMAP()
        {
            //TABLO ADI
            this.ToTable("Countys");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.CountyID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER
            this.Property(x => x.CountyName).HasMaxLength(60).IsUnicode(); //NVARCHAR OLAN KISMI VARCHAR


            //BOŞ GEÇİLEMEZ ALANLAR
            //--

            //ALAN ADLARI
            this.Property(x => x.CountyID).HasColumnName("CountyID");
            this.Property(x => x.CountyName).HasColumnName("CountyName");
          
            //VERİ TİPİ
            //--
        }
    }
}
