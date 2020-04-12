using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class SubTopic
    {
        public SubTopic()
        {
            PostSchool = new HashSet<PostSchool>();
            TopicSubTopic = new HashSet<TopicSubTopic>();
        }

        public int SubTopicId { get; set; }
        public string SubTopicName { get; set; }

        public virtual ICollection<PostSchool> PostSchool { get; set; }
        public virtual ICollection<TopicSubTopic> TopicSubTopic { get; set; }
    }
}
