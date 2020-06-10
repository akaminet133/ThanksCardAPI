using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThanksCardAPI.Models;

namespace ThanksCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogonController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public LogonController(ApplicationContext context)
        {
            _context = context;

            if (_context.User_Dep_Kanris.Count() == 0)
            {
                // Usersテーブルが空なら初期データを作成する。
                _context.User_Dep_Kanris.Add(new User_Dep_Kanri { User = new User { Cd = "admin", Password = "admin", IsUsers = true, IsManagement = true }, Section = new Section { Cd = "M", Name = "Muscle", Department = new Department { Cd = "A", Name = "Alpha" } } });
                _context.User_Dep_Kanris.Add(new User_Dep_Kanri { User =  new User { Cd = "user", Password = "user", IsUsers = false, IsManagement = false }, Section = new Section { Cd = "C", Name = "Cooker", Department = new Department { Cd = "B", Name = "Beta" } } });
                _context.SaveChanges();
            }
        }

        // POST api/logon
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            var authorizedUser = _context.Users.SingleOrDefault(x => x.Cd == user.Cd && x.Password == user.Password);
            if (authorizedUser == null)
            {
                return NotFound();
            }
            return authorizedUser;
        }
    }
}
