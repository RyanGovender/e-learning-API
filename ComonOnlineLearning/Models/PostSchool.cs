using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class PostSchool
    {
        public int PostSchoolId { get; set; }
        public int PsPostId { get; set; }
        public int PsGradeSubjectId { get; set; }
        public int PsTopicId { get; set; }
        public int PsSubTopicId { get; set; }

        public virtual GradeSubject PsGradeSubject { get; set; }
        public virtual Post PsPost { get; set; }
        public virtual SubTopic PsSubTopic { get; set; }
        public virtual Topic PsTopic { get; set; }
    }
}
