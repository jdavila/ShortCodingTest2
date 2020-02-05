using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShortCodingTest2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListifyController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get(int begin, int end, int? index)
        {
            var list = new Listify(begin, end);

            if (index.HasValue)
                return new int[] { list[index.Value] };
            
            return list;
        }
    }
}