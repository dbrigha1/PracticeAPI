using PracticeAPI.Logic;
using PracticeAPI.Models.Entity;
using PracticeAPI.Models.ViewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PracticeAPI.Controllers
{
    [Authorize]
    public class PracticesController : ApiController
    {
        private readonly IPracticeLogic _logic;
        public PracticesController(IPracticeLogic logic)
        {
            _logic = logic;
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var results = await _logic.GetAll();
                if (results != null)
                {
                    return Ok(results);
                }
                return BadRequest();
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public async Task<IHttpActionResult> Post([FromBody]PracticeViewEntity viewEntity)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _logic.Create(viewEntity);
                    return Ok();
                }
                return BadRequest();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
