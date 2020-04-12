using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class GradeSubjectTopic
    {
        public int GradeSubjectTopicId { get; set; }
        public int GstTopicId { get; set; }
        public int GstGradeSubjectId { get; set; }

        public virtual GradeSubject GstGradeSubject { get; set; }
        public virtual Topic GstTopic { get; set; }
    }
}
