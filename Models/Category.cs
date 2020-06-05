using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThanksCardAPI.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Del_flg { get; set; }
        //カテゴリー
        public long? Dep_Id { get; set; }
        public virtual Department Department{ get; set; }
    }
}
