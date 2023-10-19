using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecarIO.Persistence
{
    public class BookConfigure : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).HasMaxLength(150).IsRequired();
            builder.HasOne(b => b.Author).WithMany(b => b.Books).HasForeignKey();
            builder.HasOne(b => b.Publisher).WithMany(b => b.Books).HasForeignKey();
            builder.Property(b => b.Category).IsRequired();
            builder.Property(b => b.NumOfPages).IsRequired();
            builder.Property(b => b.Price).IsRequired();
        }
    }
}