using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class Post
    {
        public Post()
        {
            PostSchool = new HashSet<PostSchool>();
        }

        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public int? PostViews { get; set; }
        public double? PostRating { get; set; }
        public bool? PostFeatured { get; set; }
        public DateTime? PostPublishedDate { get; set; }
        public string PostAuthor { get; set; }
        public bool PostActive { get; set; }
        public string PostContent { get; set; }

        public virtual ICollection<PostSchool> PostSchool { get; set; }
    }
}
