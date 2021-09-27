using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class NotAllowedCharactersException : Exception
    {
        public IncorrectChar[] IncorrectChars { get; set; }

        public NotAllowedCharactersException(IncorrectChar[] incorrectChars)
        {
            IncorrectChars = incorrectChars;
        }
    }
}
