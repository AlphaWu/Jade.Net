//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jade.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Pictures
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string pic_url { get; set; }
        public string video_url { get; set; }
        public Nullable<int> serial_no { get; set; }
    
        public virtual Product_Info Product_Info { get; set; }
    }
}
