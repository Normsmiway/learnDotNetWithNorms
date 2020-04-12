using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrategyPatternWithDI_WithComposition.Constants;
using StrategyPatternWithDI_WithComposition.Services;

namespace StrategyPatternWithDI_WithComposition.Controllers
{
    [Route("")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentBuilder _documentBuilder;
        public DocumentController(IDocumentBuilder documentBuilder)
        {
            _documentBuilder = documentBuilder;
        }
        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var docs = await _documentBuilder.Build(DocumentProcessingStrategy.Complex, new Requests.DocumentRequest() { Body = "This document body", Name = "TestFile.html", Title = "Abide" });
            return Content(docs.Name);
        }

    }
}
