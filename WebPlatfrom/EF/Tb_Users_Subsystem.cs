//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Users_Subsystem
    {
        public int SubSystemID { get; set; }
        public string SubName { get; set; }
        public string Remarks { get; set; }
        public string API_Url { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Enabled { get; set; }
    }
}
