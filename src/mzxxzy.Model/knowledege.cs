//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mzxxzy.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class knowledege
    {
        public int know_id { get; set; }
        public string keyword { get; set; }
        public string title { get; set; }
        public string know_content { get; set; }
        public string know_type { get; set; }
        public Nullable<System.DateTime> creattime { get; set; }
        public Nullable<System.DateTime> edittime { get; set; }
        public int user_id { get; set; }
    }
}