using ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.Infra.Data.Mappings
{
    public class UserMappings : IEntityTypeConfiguration<User>
    {
       public void  Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(x => x.Id).IsRequired();
            entity.Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}