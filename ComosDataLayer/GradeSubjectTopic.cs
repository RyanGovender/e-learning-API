//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComosDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class GradeSubjectTopic
    {
        public int GradeSubjectTopicID { get; set; }
        public int GST_TopicID { get; set; }
        public int GST_GradeSubjectID { get; set; }
    
        public virtual GradeSubject GradeSubject { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
