//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_Members
    {
        public int Id { get; set; }
        public int Project_Id { get; set; }
        public int Member_Id { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}