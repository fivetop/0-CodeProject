//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayItemDB
    {
        public long PlayItemId { get; set; }
        public long playflag_onair { get; set; }
        public long idno { get; set; }
        public long chno { get; set; }
        public string kind { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string state { get; set; }
        public Nullable<long> playcnt { get; set; }
        public Nullable<System.DateTime> current { get; set; }
        public Nullable<System.DateTime> duration { get; set; }
        public long p_run { get; set; }
    }
}
