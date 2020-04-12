using System;
using System.Collections.Generic;

namespace ComonOnlineLearning.Models
{
    public partial class Grade
    {
        public Grade()
        {
            GradeSubject = new HashSet<GradeSubject>();
        }

        public int GradeId { get; set; }
        public string Grade1 { get; set; }

        public virtual ICollection<GradeSubject> GradeSubject { get; set; }
    }
}
