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
    
    public partial class Project
    {
        public Project()
        {
            this.ProjectTasks = new HashSet<ProjectTask>();
        }
    
        public System.Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ProjectManager { get; set; }
        public int Status { get; set; }
    
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
