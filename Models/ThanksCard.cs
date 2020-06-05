using System;
using System.Collections.Generic;

namespace ThanksCardAPI.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public long FromId { get; set; }
        public virtual User From { get; set; }
        public long ToId { get; set; }
        public virtual User To { get; set; }
        public DateTime CreatedDateTime { get; set; }
        //ƒJƒeƒSƒŠ[
        public long? Category_Id { get; set; }
        public virtual Category Categorys{ get; set; }
    }
}
