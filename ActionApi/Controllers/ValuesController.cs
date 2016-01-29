using System.Collections.Generic;
using System.Web.Http;
using ActionService;

namespace Action.API.Controllers
{
  //  [Authorize]
    public class ValuesController : ApiController
    {
        protected readonly IService _service;
        public ValuesController(IService service)
        {
            _service = service;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            var member = _service.GetMember(1);
            return new[] { "value1", "value2", member.CompanyName };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
