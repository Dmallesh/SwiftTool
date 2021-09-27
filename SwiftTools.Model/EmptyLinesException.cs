using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class EmptyLinesException : IncorrectLinesException
    {
        public EmptyLinesException(int[] incorrectLines) : base(incorrectLines)
        {
        }
    }
}
