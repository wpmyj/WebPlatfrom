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
    
    public partial class Tb_Logs_M4Channel
    {
        public int ID { get; set; }
        public string DeviceKey { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public string FunctionName { get; set; }
        public Nullable<int> ElapsedTime { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public Nullable<int> Result { get; set; }
    }
}
