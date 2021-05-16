using LanguageTrainer.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LanguageTrainer.API.Controllers
{
    [ApiController]
    [Route("/v1/api/media")]
    public class MediaController : ControllerBase
    {
        private readonly IHttpContextAccessor _context;
        private List<Media> sources = new List<Media>();
        public MediaController(IHttpContextAccessor context)
        {
            _context = context;

            sources.Add(new Media
            {
                Id = 1,
                Name = "epa.mp3",
                Path = _context.HttpContext.Request.PathBase.Value + "/temp"
            });
            sources.Add(new Media { Id = 2, Name = "arrozconposho.mp3" });
            sources.Add(new Media { Id = 3, Name = "arepa.mp3" });
            sources.Add(new Media { Id = 4, Name = "queso.mp3" });
        }

        [HttpGet("")]
        public ActionResult<List<object>> GetAll()
        {
            return Ok(sources);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var file = sources.Where(x => x.Id == id);

            if (file == null)
            {
                return NotFound();
            }

            try
            {
                var stream = new FileStream(@".\temp\" + file.First().Name, FileMode.Open, FileAccess.Read, FileShare.Read);

                return File(stream, "audio/mp3", true);
            }
            catch(Exception ex)
            {
                return new BadRequestResult();
            }
        }
    }
}