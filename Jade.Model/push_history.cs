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
    
    public partial class Push_History
    {
        public int id { get; set; }
        public int push_message_id { get; set; }
        public string title { get; set; }
        public bool android_push_state { get; set; }
        public bool ios_push_state { get; set; }
        public System.DateTime create_time { get; set; }
        public string description { get; set; }
        public int type { get; set; }
        public string richContent { get; set; }
        public int user_id { get; set; }
    
        public virtual Push_Message Push_Message { get; set; }
        public virtual User User { get; set; }
    }
}
