//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class L2_Assessments_Results
    {
        public System.Guid RecordId { get; set; }
        public int Condition0 { get; set; }
        public int Condition1 { get; set; }
        public int Condition2 { get; set; }
        public int Condition3 { get; set; }
        public int Condition4 { get; set; }
        public int Condition5 { get; set; }
        public int Condition6 { get; set; }
        public bool Skipped { get; set; }
        public int SkippedReason { get; set; }
        public string Comment { get; set; }
        public Nullable<int> SafetyScore { get; set; }
        public Nullable<int> FunctionalityScore { get; set; }
        public Nullable<int> AppearanceScore { get; set; }
        public System.Guid Asset_Id { get; set; }
        public System.Guid Task_TaskId { get; set; }
    
        public virtual L2_Assessments L2_Assessments { get; set; }
    }
}
