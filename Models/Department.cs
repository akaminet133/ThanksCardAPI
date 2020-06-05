using System.Collections.Generic;

namespace ThanksCardAPI.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Cd { get; set; }
        public string Name { get; set; }
        public int Del_flg { get; set; }
        // 1対多: Department エンティティには複数の Section エンティティが属する
        public virtual ICollection<Section> Sections { get; set; }
    }
}
