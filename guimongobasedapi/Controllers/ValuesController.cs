using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace guimongobasedapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5c58f44c4d8f003f788924b8
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            // Declaration of data types 
            bool result;
            ObjectId value;

            // Validate if the String is a valid bson.ObjectId
            result = ObjectId.TryParse(id, out value);

            if (result) { 
                    return "Valid ObjectId";
                }
            return "Not Valid ObjectId";


        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
