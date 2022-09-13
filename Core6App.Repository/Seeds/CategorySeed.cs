﻿using Core6App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core6App.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Kalemler",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Kitaplar",
                },
                new Category()
                {
                    Id = 3,
                    Name = "Defterler",
                });
        }
    }
}
