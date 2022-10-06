using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eit
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatTransportController : Controller
    {
        [HttpGet("route")]
        public IActionResult Index()
        {
            return Ok(new ResponseDTO(1, 2));
        }
    }

    public class ResponseDTO
    {
        public ResponseDTO(int price, int time)
        {
            Price = price;
            Time = time;
        }
        public double Price { get; set; }
        public double Time { get; set; }
    }
    public class RequestDTO
    {
        public string Source { get; set; }
        public string destination { get; set; }
        public string date { get; set; }
        public double weight { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public string type { get; set; }
    }
}



