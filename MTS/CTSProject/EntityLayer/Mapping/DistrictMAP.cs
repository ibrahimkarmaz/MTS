using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class DistrictMAP:EntityTypeConfiguration<District>
    {
        public DistrictMAP()
        {

            //TABLO ADI
            this.ToTable("Districts");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.DistrictID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER
            this.Property(x => x.DistrictName).HasMaxLength(250).IsUnicode(); //NVARCHAR OLAN KISMI VARCHAR


            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(x => x.DistrictName).IsRequired();

            //ALAN ADLARI
            this.Property(x => x.DistrictID).HasColumnName("DistrictID");
            this.Property(x => x.DistrictName).HasColumnName("DistrictName");
            this.Property(x => x.CountyID).HasColumnName("CountyID");

            //VERİ TİPİ
            //--
        }
    }
}
