using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreStudy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "HelloWorld1", "HelloWorld2","HelloWorld3" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string result;
            switch (id)
            {
                case 1:
                    result = "HelloWorld1";
                    break;
                case 2:
                    result = "HelloWorld2";
                    break;
                case 3:
                    result = "HelloWorld3";
                    break;
                default:
                    result = "HelloWorld" + id.ToString();
                    break;
            }
            return result;
        }
        // POST api/<ValuesController>
        [HttpPost]
        public string Post([FromBody]string value)
        {
            return "Post:" + "HelloWorld" + value ;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Put:HelloWorld" + id + " to " +  value ; 
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Delete:HelloWorld" + id.ToString() ;
        }
    }
}
