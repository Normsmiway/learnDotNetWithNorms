using StrategyPatternWithDI_WithComposition.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Constants
{
    public class DocumentType
    {
        public const string Pdf = "PDF";
        public const string MsDocs = "MSDOCS";
        public const string Html = "Html";
    }


    public class DocumentProcessingStrategy
    {
        public const string Simple = nameof(SimpleDocumentProcessor);
        public const string Complex = nameof(ComplexDocumentProcessor);
    }
}
