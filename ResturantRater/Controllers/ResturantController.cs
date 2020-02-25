using ResturantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        [HttpPost]
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


        // GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Resturant> resturants = await _context.Resturants.ToListAsync();
            return Ok(resturants);
        }

        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Resturant resturant = await _context.Resturants.FindAsync(id);
            if (resturant == null)
            {
                return NotFound();
            }

            return Ok(resturant);
        }

        // PUT (Update)
        [HttpPut]
        public async Task<IHttpActionResult> UpdateResturant([FromUri]int id, [FromBody]Resturant model)
        {
            if (ModelState.IsValid && model != null)
            {
                //This is our entity
                Resturant resturant = await _context.Resturants.FindAsync(id);

                if (resturant != null)
                {
                    resturant.Name = model.Name;
                    resturant.Rating = model.Rating;
                    resturant.Style = model.Style;
                    resturant.DollarSigns = model.DollarSigns;

                    await _context.SaveChangesAsync();

                    return Ok();
                }

                return NotFound();
            }

            return BadRequest(ModelState);
        }



        // DELETE BY ID
    }
}
