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
    
    public partial class Tb_Face_Image
    {
        public int ID { get; set; }
        public int FeatureID { get; set; }
        public int UserID { get; set; }
        public int FaceGroupID { get; set; }
        public string FaceImage { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
