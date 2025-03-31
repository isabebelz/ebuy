using ebuy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ebuy.Infra.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("T_USER");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("PK_USER")
                .IsRequired();

            builder.Property(u => u.Name)
                .HasColumnName("TX_NAME")
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("T_EMAIL")
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnName("T_PASSWORD")
                .IsRequired();

            builder.Property(u => u.RegistrationDate)
                .HasColumnName("DT_REGISTRATION_DATE")
                .IsRequired();

            builder.Property(u => u.Active)
                .HasColumnName("FL_ACTIVE")
                .IsRequired();
        }
    }
}
