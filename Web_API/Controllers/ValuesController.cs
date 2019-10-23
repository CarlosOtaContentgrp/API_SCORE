using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API.Models;

namespace Web_API.Controllers
{
    /// <summary>Values Controller</summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ValuesController : ApiController
    {
        db_Access_Layer.db dblayer = new db_Access_Layer.db();
        /// <summary>Adds the points.</summary>
        /// <param name="point_">The point.</param>
        /// <returns>Message</returns>
        [HttpPost]
        public IHttpActionResult AddPoints([FromBody]Points point_)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                dblayer.addPoints(point_);
                return Ok("Success");
            }
            catch (Exception)
            {

                return Ok("Error!!!");
            }
        }
    }
}
