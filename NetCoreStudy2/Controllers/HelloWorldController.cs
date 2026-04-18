using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreStudy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private static readonly List<Hellos> _hellos = new List<Hellos>
        {
            new Hellos{HelloID = 1,Title = "HelloWorld1",Content = "第一筆HelloWorld資料"},
            new Hellos{HelloID = 2,Title = "HelloWorld2",Content = "第二筆HelloWorld資料"},
            new Hellos{HelloID = 3,Title = "HelloWorld3",Content = "第三筆HelloWorld資料"},
        };
        // GET所有HELLOS
        [HttpGet]
        public IEnumerable<Hellos> Get()
        {
            return _hellos;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //查詢語法 (Query Syntax)
            //var result = from a in Hellos
            //             where a.HelloID == id
            //             select a;

            //方法語法 (Method Syntax)、lambda
            var result = _hellos.FirstOrDefault(a => a.HelloID == id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post(Hellos value)
        {
            _hellos.Add(value);
            return Ok(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Hellos value)
        {
            //查詢語法 (Query Syntax)
            //var update = (from a in Hellos
            //             where a.HelloID == id
            //             select a).SingleOrDefault();
            //方法語法 (Method Syntax)、lambda
            var update = _hellos.SingleOrDefault(a => a.HelloID == id);

            if (update != null)
            {
                update.Title = value.Title;
                update.Content = value.Content;
            }
            else
            {
                return NotFound();
            }
            return Ok(update);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //查詢語法 (Query Syntax)
            //var delete = (from a in Hellos
            //              where a.HelloID == id
            //              select a).SingleOrDefault();
            //方法語法 (Method Syntax)、lambda
            var delete = _hellos.SingleOrDefault(a => a.HelloID == id);

            if (delete != null)
                _hellos.Remove(delete);
            else
                return NotFound();
            return Ok(delete);
        }
    }
}
