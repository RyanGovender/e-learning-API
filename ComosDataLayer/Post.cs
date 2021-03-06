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
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.PostSchools = new HashSet<PostSchool>();
        }
    
        public int PostID { get; set; }
        public string Post_Title { get; set; }
        public Nullable<int> Post_Views { get; set; }
        public Nullable<double> Post_Rating { get; set; }
        public Nullable<bool> Post_Featured { get; set; }
        public Nullable<System.DateTime> Post_Published_Date { get; set; }
        public string Post_Author { get; set; }
        public bool Post_Active { get; set; }
        public string Post_Content { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostSchool> PostSchools { get; set; }
    }
}
