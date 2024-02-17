using Microsoft.AspNetCore.Mvc;
using PrintAPI.Models;
using PrintAPI.Services;
using PrintAPI.Validation;

namespace PrintAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintController : ControllerBase
    {
        private readonly IPrintService _printService;

        public PrintController(IPrintService printService)
        {
            _printService = printService;
        }

        [HttpPost]
        public IActionResult Print([FromBody] PrintRequest request)
        {
            // Valide a solicitação
            string errorMessage;
            if (!RequestValidator.ValidatePrintRequest(request, out errorMessage))
            {
                return BadRequest(new {error=errorMessage});
            }

            try
            {
                _printService.printDocument(request.IPAddress, request.ProductName, request.ProductWeight);

                return Ok(new { success = "Impressão enviada com sucesso." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new{error = ex.Message});
            }
        }
    }
}
