//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eq.model.entitymodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnswerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnswerType()
        {
            this.EQTrackingItemAnswers = new HashSet<EQTrackingItemAnswer>();
            this.EQTrackingItemAnswerTemplates = new HashSet<EQTrackingItemAnswerTemplate>();
        }
    
        public int Id { get; set; }
        public string TypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQTrackingItemAnswer> EQTrackingItemAnswers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQTrackingItemAnswerTemplate> EQTrackingItemAnswerTemplates { get; set; }
    }
}