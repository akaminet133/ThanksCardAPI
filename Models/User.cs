using System.Collections.Generic;
namespace ThanksCardAPI.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Cd { get; set; }
        public string F_name { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }
        public string E_mail { get; set; }
        public bool IsUsers { get; set; }
        public bool IsManagement { get; set; }
        public bool IsAdmin { get; set; }
        public int Del_flg { get; set; }


        // 1対多: User エンティティには複数の UDK エンティティが属する
        public virtual ICollection<User_Dep_Kanri> User_Dep_kanris { get; set; }
    }
}
