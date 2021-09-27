using SwiftTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftTools.WebApi.ViewModel
{
    public class ParsingResult
    {
        /// <summary>
        /// Parsed MT 101 messages
        /// </summary>
        public MT101Message[] MT101 { get; set; }
    }
}
