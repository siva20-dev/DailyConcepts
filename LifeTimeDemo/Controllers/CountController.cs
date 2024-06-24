using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LifeTimeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        private readonly IFirstCounter firstCounter;

        private readonly ISecondCounter secondCounter;

        public CountController(IFirstCounter firstCounter, ISecondCounter secondCounter)
        {
            this.firstCounter = firstCounter;
            this.secondCounter = secondCounter;

        }
        
        // GET: api/<CountController>
        [HttpGet]
        public int Get()
        {
            firstCounter.IncrementAndGet();
            return secondCounter.IncrementAndGet();
        }

    }
}
