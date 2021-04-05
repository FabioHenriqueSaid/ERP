using ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ERP.Infra.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                   new User { Id = 1, Name = "Fabio" }
                );
            return builder;
        }
    }
}