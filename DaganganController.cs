using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace atk
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaganganController : ControllerBase
    {
        public static List<Dagangan> dagang = new List<Dagangan>();
        public DaganganController() { }

        [HttpGet]
        public IEnumerable<Dagangan> Get()
        {
            return dagang;
        }

        [HttpGet("{id}")]
        public Dagangan Get(int id)
        {
            return dagang[id];
        }

        [HttpPost]
        public void Post(Dagangan mvs)
        {
            dagang.Add(mvs);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //tes
            dagang.RemoveAt(id);
        }

    }
}
