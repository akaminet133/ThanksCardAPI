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
        public long? User_Id { get; set; }
        public virtual User User{ get; set; }
        // 多対1: Section エンティティは1つの UDK エンティティに属する
        public long? Section_Id { get; set; }
        public virtual Section Section { get; set; }

    }
}
