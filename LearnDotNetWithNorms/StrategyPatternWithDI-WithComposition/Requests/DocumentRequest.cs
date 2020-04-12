using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Requests
{
    public class DocumentRequest
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
    }
}
