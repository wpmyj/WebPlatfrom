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
    
    public partial class V_Device_Logs_eSensor_User
    {
        public Nullable<int> ID { get; set; }
        public string Mac { get; set; }
        public string DeviceName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public Nullable<int> Channel { get; set; }
        public Nullable<int> nIn { get; set; }
        public Nullable<int> nOut { get; set; }
        public Nullable<double> InSpeed { get; set; }
        public Nullable<double> OutSpeed { get; set; }
        public Nullable<int> ZoneNum { get; set; }
        public Nullable<int> DataID { get; set; }
        public Nullable<decimal> Lng { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
    }
}
