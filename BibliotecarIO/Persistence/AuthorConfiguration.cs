using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecarIO.Persistence
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(150).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(250).IsRequired();
            
        }
    }
}