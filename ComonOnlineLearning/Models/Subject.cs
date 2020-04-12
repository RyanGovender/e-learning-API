using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class Subject
    {
        public Subject()
        {
            GradeSubject = new HashSet<GradeSubject>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
        public bool SubjectStatus { get; set; }
        public string SubjectCoverUrl { get; set; }

        public virtual ICollection<GradeSubject> GradeSubject { get; set; }
    }
}
