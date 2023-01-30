using Core.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Model.Concrete
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Likes = new List<Like>();
            Comments = new List<Comment>();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        [NotMapped]

        public IFormFile ImagePath { get; set; }

        //Navigation property

        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get;set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
