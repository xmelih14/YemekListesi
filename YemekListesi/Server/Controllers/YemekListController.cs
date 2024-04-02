using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YemekListesi.Server.Data;
using YemekListesi.Shared;

namespace YemekListesi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YemekListController : ControllerBase
    {
        private readonly DataContext _context;

        public YemekListController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Yemek>>> GetYemekList()
        {
            var yemekli = await _context.Yemeks.ToListAsync();
            return Ok(yemekli);
        }

    }
}
