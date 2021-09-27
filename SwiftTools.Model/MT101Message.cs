using System;

namespace SwiftTools.Model
{
    public class MT101Message
    {
        /// <summary>
        /// MT 101 sequence A
        /// </summary>
        public MT101SequenceA SequenceA { get; set; }

        /// <summary>
        /// MT 101 sequence B
        /// </summary>
        public MT101SequenceB[] SequenceB { get; set; }

        /// <summary>
        /// Whole block 4 data
        /// </summary>
        public string Raw { get; set; }

        /// <summary>
        /// Incorrect tags.
        /// </summary>
        public TagError[] Errors { get; set; }
    }
}
