using Labb4_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labb4_MVCRazor.Data.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.PhoneNumber)
                .HasColumnName("Phone_Number")
                .HasMaxLength(50);

            builder.HasData(
                new List<Customer>
                {
                    new Customer
                    {
                        Id = 1,
                        Name = "Oliver Rodin",
                        Email = "oliver@rodin.com",
                        PhoneNumber = "070-3425467",
                        Address = "Lyckogatan 23"
                    },
                    new Customer
                    {
                        Id = 2,
                        Name = "Anna Andersson",
                        Email = "anna@andersson.com",
                        PhoneNumber = "070-0985467",
                        Address = "Bergsvägen 32"
                    },
                    new Customer
                    {
                        Id = 3,
                        Name = "Fredrik Fredriksson",
                        Email = "fredrik@fredriksson.com",
                        PhoneNumber = "070-3400067",
                        Address = "Apparatgatan 1"
                    },
                    new Customer
                    {
                        Id = 4,
                        Name = "Annika Lantz",
                        Email = "annika@lantz.com",
                        PhoneNumber = "070-3420107",
                        Address = "Alftavägen 20"
                    },
                    new Customer
                    {
                        Id = 5,
                        Name = "Jessica Andersson",
                        Email = "jessica@andersson.com",
                        PhoneNumber = "070-3420000",
                        Address = "Hjulgatan 45"
                    },
                    new Customer
                    {
                        Id = 6,
                        Name = "Magnus Dixon",
                        Email = "magnus@dixon.com",
                        PhoneNumber = "070-3421111",
                        Address = "Skogsgatan 100"
                    }
                });
        }
    }
}
