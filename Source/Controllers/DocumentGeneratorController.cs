using Microsoft.AspNetCore.Mvc;
using PDFDemo.Interfaces;

namespace PDFDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentGeneratorController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentGeneratorController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pdfFile = _documentService.GeneratePdfFromString();
            return File(pdfFile, "application/octet-stream", "SimplePdf.pdf");
        }

        [HttpGet("GetPdfFromRazor")]
        public IActionResult GetPdfFromRazor()
        {
            var pdfFile = _documentService.GeneratePdfFromRazorView();
            return File(pdfFile, "application/octet-stream", "RazorPdf.pdf");
        }
    }
}
