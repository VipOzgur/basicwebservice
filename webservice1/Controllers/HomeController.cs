using Microsoft.AspNetCore.Mvc;
using isKatmani;

namespace webservice1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        VerilerSP _context =new VerilerSP();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Liste());
        }
        [HttpPost]
        public IActionResult Add(string data) {
            _context.Ekle(data); 
            return Ok(data+ " adındaki eleman Eklendi");
        }
        [HttpDelete]
        public IActionResult Delete(int id) {
            _context.Sil(id); return Ok(id + " id li eleman  Silindi");
        }
    }
}
