using Blog.Model.Concrete;
using Core.Model.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);

            base.Configure(builder);
        }
    }
}
