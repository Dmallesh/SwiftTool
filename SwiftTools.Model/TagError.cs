using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class TagError
    {
        public enum TagErrorType {
            /// <summary>
            /// Mandatory tag not exists
            /// </summary>
            MandatoryTagNotExists,
            /// <summary>
            /// Tag has incorrect value
            /// </summary>
            IncorrectTagValue
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag">Tag</param>
        /// <param name="value">Incorrect value from tag (if tag contains many lines, all lines with original lines separators should be added)</param>
        /// <param name="errorType">Error reason</param>
        /// <param name="numberOfSequenceB">
        /// Number of sequence B. 
        /// If the tag applies to section A the NumberOfSequenceB should be set to 0.
        /// First section B has value 1, next has 2 etc...
        /// </param>
        public TagError(string tag, string value, TagErrorType errorType, int numberOfSequenceB)
        {
            Tag = tag;
            Value = value;
            ErrorType = errorType;
            NumberOfSequenceB = numberOfSequenceB;
        }

        /// <summary>
        /// Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Incorrect value from tag (if tag contains many lines, all lines with original lines separators should be added)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Error reason
        /// </summary>
        public TagErrorType ErrorType { get; set; }

        /// <summary>
        /// Number of sequence B. 
        /// If the tag applies to section A the NumberOfSequenceB should be set to 0.
        /// First section B has value 1, next has 2 etc...
        /// </summary>
        public int NumberOfSequenceB { get; set; }
    }
}
