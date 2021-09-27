using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class IncorrectLinesException : Exception
    {
        public int[] IncorrectLines { get; set; }

        public IncorrectLinesException(int[] incorrectLines)
        {
            IncorrectLines = incorrectLines;
        }
    }
}
