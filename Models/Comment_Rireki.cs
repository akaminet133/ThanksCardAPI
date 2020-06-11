using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class Comment_Rireki
    {
        public long Id { get; set; }
        public long Com_Rno { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public long ThanksCardId { get; set; }
        public ThanksCards ThanksCard { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}
