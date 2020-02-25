using ResturantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResturantRater.Controllers
{   //return status codes
    public class ResturantController : ApiController
    {
        private readonly ResturantDbContext _context = new ResturantDbContext();
        // POST
        public async Task<IHttpActionResult> PostResturant(Resturant resturant)
        {
            if (ModelState.IsValid && resturant != null)
            {
                _context.Resturants.Add(resturant);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}
