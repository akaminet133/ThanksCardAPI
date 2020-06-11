using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class User_Dep_Kanri
    {
        public long Id { get; set; }
        // 多対1: User エンティティは1つの UDK エンティティに属する
        public long UserId { get; set; }
        public virtual User User{ get; set; }
        // 多対1: Section エンティティは1つの UDK エンティティに属する
        public long SectionId { get; set; }
        public virtual Section Section { get; set; }

        // 1対多: ThanksCard エンティティには複数の UDK エンティティが属する
        //public virtual ICollection<ThanksCards> ThanksCards { get; set; }
    }
}
