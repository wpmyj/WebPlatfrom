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
    
    public partial class V_FP_DVR
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Enabled { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> Port { get; set; }
        public string Account { get; set; }
        public string PWD { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public Nullable<decimal> Lng { get; set; }
    }
}
