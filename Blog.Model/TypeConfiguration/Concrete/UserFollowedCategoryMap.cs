using Blog.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class UserFollowedCategoryMap : IEntityTypeConfiguration<UserFollowedCategories>
    {
        public void Configure(EntityTypeBuilder<UserFollowedCategories> builder)
        {
            builder.HasKey(a => new {a.AppUserID,a.CategoryID});

            builder.HasOne(a => a.AppUser).WithMany(a => a.UserFollowedCategories).HasForeignKey(a => a.AppUserID);

            builder.HasOne(a => a.Category).WithMany(a => a.UserFollowedCategories).HasForeignKey(a => a.CategoryID);
        }
    }
}
