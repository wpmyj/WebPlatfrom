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
    
    public partial class Tb_Logs_LedCall
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int DeviceID { get; set; }
        public string FunctionName { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public int Result { get; set; }
        public System.DateTime SaveDate { get; set; }
        public int ElapsedTime { get; set; }
    }
}
