using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrategyPatternWithDI.Constants;
using StrategyPatternWithDI.Services;

namespace StrategyPatternWithDI.Controllers
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
            var docs = await _documentBuilder.Build(DocumentType.Pdf, new Requests.DocumentRequest() { Body = "This document body", Name = "TestFile.html", Title = "Abide" });
            return Content(docs.Name);
        }

    }
}
