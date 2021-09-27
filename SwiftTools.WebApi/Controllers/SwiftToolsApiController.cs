using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwiftTools.Model;
using SwiftTools.MT101Parser;
using SwiftTools.WebApi.ViewModel;

namespace SwiftTools.WebApi.Controllers
{
    /// <summary>
    /// TODO: finish implementation
    /// </summary>
    public class SwiftToolsApiController : ControllerBase
    {
        /// <summary>
        /// Should returns json with integer value:
        /// 0 - if content is correct;
        /// 1 - if content is empty (NoDataException);
        /// 2 - format is incorrect (MTFormatException);
        /// 3 - if content contains empty lines (EmptyLinesException);
        /// 4 - if content contains lines starts with "-" (IncorrectLinesException);
        /// 5 - if content contains not allowed charactres
        /// 
        /// TODO: The function should be available as "/api/swift/validate-format-mt101".
        /// </summary>
        /// <param name="data">Contains swift MT 101 messages</param>
        /// <returns></returns>
        public int ValidateMT101Content([FromBody] MT101DataModel data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Should returns json with parsed MT 101 messages. 
        /// 
        /// TODO: The function should be available as "/api/swift/parse-mt101".
        /// </summary>
        /// <param name="data">Contains swift MT 101 messages</param>
        /// <returns></returns>
        public ParsingResult ParseMT101Content([FromBody] MT101DataModel data)
        {
            throw new NotImplementedException();
        }
    }
}
