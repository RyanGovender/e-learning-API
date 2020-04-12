using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class TopicSubTopic
    {
        public int TopicSubTopicId { get; set; }
        public int TstTopicId { get; set; }
        public int TstSubTopicId { get; set; }

        public virtual SubTopic TstSubTopic { get; set; }
        public virtual Topic TstTopic { get; set; }
    }
}
