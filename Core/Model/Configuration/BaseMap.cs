using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Configuration
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        //Bu sınıf diğer sınıflara kalıtım vereceği için configure metodunu virtual olarak yazdık ki diğer sınıflar kendilerine göre düzenleyebilsin.

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.CreatedDate).IsRequired(true);
            builder.Property(a => a.DeletedDate).IsRequired(false);
            builder.Property(a => a.UpdateDate).IsRequired(false);
        }
    }
}
