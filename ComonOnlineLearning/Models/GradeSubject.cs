using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class GradeSubject
    {
        public GradeSubject()
        {
            GradeSubjectTopic = new HashSet<GradeSubjectTopic>();
            PostSchool = new HashSet<PostSchool>();
        }

        public int GradeSubjectId { get; set; }
        public int GsGradeId { get; set; }
        public int GsSubjectId { get; set; }
        public string GradeSubjectDescription { get; set; }

        public virtual Grade GsGrade { get; set; }
        public virtual Subject GsSubject { get; set; }
        public virtual ICollection<GradeSubjectTopic> GradeSubjectTopic { get; set; }
        public virtual ICollection<PostSchool> PostSchool { get; set; }
    }
}
