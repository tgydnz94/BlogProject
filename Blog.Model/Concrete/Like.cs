using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.Concrete
{
    public class Like
    {
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set; }
    }
}
