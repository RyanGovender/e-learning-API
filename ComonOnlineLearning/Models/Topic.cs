using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class Topic
    {
        public Topic()
        {
            GradeSubjectTopic = new HashSet<GradeSubjectTopic>();
            PostSchool = new HashSet<PostSchool>();
            TopicSubTopic = new HashSet<TopicSubTopic>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string TopicDescription { get; set; }

        public virtual ICollection<GradeSubjectTopic> GradeSubjectTopic { get; set; }
        public virtual ICollection<PostSchool> PostSchool { get; set; }
        public virtual ICollection<TopicSubTopic> TopicSubTopic { get; set; }
    }
}
