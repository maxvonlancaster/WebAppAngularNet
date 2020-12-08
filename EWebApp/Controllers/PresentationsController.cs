using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EWebApp.DAL.Context;
using EWebApp.DAL.Entities;
using EWebApp.BLL.Interfaces;
using EWebApp.BLL.Exceptions;
using EWebApp.Models;
using System.IO;

namespace EWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresentationsController : ControllerBase
    {
        private readonly IPresentationService _presentationService;

        public PresentationsController(IPresentationService presentationService)
        {
            _presentationService = presentationService;
        }

        // GET: api/Presentations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Presentation>>> GetPresentations()
        {
            var presentations = await _presentationService.GetPresentations(0, 10);
            return new JsonResult(presentations);
        }

        // GET: api/Presentations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Presentation>> GetPresentation(long id)
        {
            try
            {
                var presentation = await _presentationService.GetPresentation(id);
                return presentation;
            }
            catch (ItemNotFoundEsception ex) 
            {
                return NotFound(ex.Message);
            }
        }

        // PUT: api/Presentations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPresentation(long id, Presentation presentation)
        {
            try
            {
                await _presentationService.PutPresentation(id, presentation);
            }
            catch (BadRequestException bex)
            {
                return BadRequest(bex.Message);
            }
            catch (ItemNotFoundEsception iex) 
            {
                return NotFound(iex.Message);
            }

            return NoContent();
        }

        // POST: api/Presentations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Presentation>> PostPresentation([FromForm]PresentationModel presentationModel)
        {
            Presentation presentation = new Presentation()
            {
                PresentationName = presentationModel.PresentationName,
                PresentationTopic = presentationModel.PresentationTopic
            };

            byte[] fileData = null;
            using (var binaryReader = new BinaryReader(presentationModel.File.OpenReadStream())) 
            {
                fileData = binaryReader.ReadBytes((int)presentationModel.File.Length);
            }
            presentation.File = fileData;

            await _presentationService.PostPresentation(presentation);

            return CreatedAtAction("GetPresentation", new { id = presentation.PresentationId }, presentation);
        }

        // DELETE: api/Presentations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Presentation>> DeletePresentation(long id)
        {
            try
            {
                var presentation = await _presentationService.DeletePresentation(id);
                return presentation;
            }
            catch (ItemNotFoundEsception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
