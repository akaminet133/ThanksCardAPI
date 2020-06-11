using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThanksCardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ThanksCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FavController(ApplicationContext context)
        {
            _context = context;
        }

        /** Put api/Fav
        [HttpPut("{id}")]
        public Task<IActionResult> PutFav(long id, ThanksCard thanksCard)
        {
            var foundthankscard = _context.ThanksCards.Single(x => x.Id == id);
            if (foundthankscard == null)
            {
                NotFound();
            }
            // 取得したオブジェクトに変更を加える
            thanksCard.Fav += 1;

            // ここで初めてUpdate文が発行される
            _context.SaveChanges();
        }*/
    }
}