using System;
using System.Collections.Generic;

namespace ThanksCardAPI.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public long Fav { get; set; }
        public DateTime CreatedDateTime { get; set; }

        //送信者情報 : 多対1
        public long FromId { get; set; }
        public virtual User From { get; set; }
        //受信者情報
        public long ToId { get; set; }
        public virtual User To { get; set; }
        //カテゴリー
        public long CategoryId { get; set; }
        public virtual Category Category{ get; set; }
    }
}
