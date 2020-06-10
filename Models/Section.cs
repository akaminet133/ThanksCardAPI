using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class Section
    {
        public long Id { get; set; }
        public string Cd { get; set; }
        public string Name { get; set; }
        public int Del_flg { get; set; }

        // 多対1: Section エンティティは1つの Department エンティティに属する
        public long DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        // 1対多: Section エンティティには複数の Udk エンティティが属する
        public virtual ICollection<User_Dep_Kanri> User_Dep_kanris { get; set; }
    }
}
