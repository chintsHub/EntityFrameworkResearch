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
    
    public partial class ProjectTask
    {
        public System.Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public int Status { get; set; }
        public string Comments { get; set; }
        public string AssignedTo_Id { get; set; }
        public System.Guid Project_ProjectId { get; set; }
    
        public virtual L2_Assessments L2_Assessments { get; set; }
        public virtual Project Project { get; set; }
    }
}
