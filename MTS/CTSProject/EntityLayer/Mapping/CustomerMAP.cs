using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CustomerMAP:EntityTypeConfiguration<Customer>
    {
        public CustomerMAP()
        {
            //TABLO ADI
            this.ToTable("Customers");

            //BİRİNCİ ANAHTAR
            this.HasKey(x => x.CustomerID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.TCNO).IsUnique();
            this.HasIndex(x => x.CustomerMobilePhone).IsUnique();
            this.HasIndex(x => x.CustomerMail).IsUnique();

            //EN FAZLA KARAKTER
            this.Property(x => x.TCNO).HasMaxLength(11);
            this.Property(x => x.CustomerName).HasMaxLength(20);
            this.Property(x => x.CustomerSurnama).HasMaxLength(20);
            this.Property(x => x.CustomerMobilePhone).HasMaxLength(15);
            this.Property(x => x.CustomerOfficePhone).HasMaxLength(15);
            this.Property(x => x.CustomerMail).HasMaxLength(40);
            this.Property(x => x.CustomerHomeAddress).HasMaxLength(250);
            this.Property(x => x.CustomerNote).HasMaxLength(250);

            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(x => x.TCNO).IsRequired();
            this.Property(x => x.CustomerName).IsRequired();
            this.Property(x => x.CustomerSurnama).IsRequired();
            this.Property(x => x.CustomerGender).IsRequired();
            this.Property(x => x.CustomerDateOfBirth).IsRequired();
            this.Property(x => x.CustomerMobilePhone).IsRequired();
            this.Property(x => x.CustomerMail).IsRequired();
            this.Property(x => x.CustomerCreateDate).IsRequired();
            this.Property(x => x.CustomerHomeAddress).IsRequired();
            this.Property(x => x.Archive).IsRequired();

            //ALAN ADLARI
            this.Property(x => x.CustomerID).HasColumnName("CustomerID");
            this.Property(x => x.TCNO).HasColumnName("TCNO");
            this.Property(x => x.CustomerName).HasColumnName("CustomerName");
            this.Property(x => x.CustomerSurnama).HasColumnName("CustomerSurnama");
            this.Property(x => x.CustomerGender).HasColumnName("CustomerGender");
            this.Property(x => x.CustomerDateOfBirth).HasColumnName("CustomerDateOfBirth");
            this.Property(x => x.CustomerMobilePhone).HasColumnName("CustomerMobilePhone");
            this.Property(x => x.CustomerOfficePhone).HasColumnName("CustomerOfficePhone");
            this.Property(x => x.CustomerMail).HasColumnName("CustomerMail");
            this.Property(x => x.CustomerCreateDate).HasColumnName("CustomerCreateDate");
            this.Property(x => x.CustomerHomeAddress).HasColumnName("CustomerHomeAddress");
            this.Property(x => x.CustomerNote).HasColumnName("CustomerNote");
            this.Property(x => x.Archive).HasColumnName("Archive");

            //VERİ TİPİ
            this.Property(x=>x.TCNO).HasColumnType("char");

        }
    }
}
