using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class MT101SequenceA
    {
        /// <summary>
        /// Sender Reference (20)
        /// </summary>
        public string SenderReference { get; set; }

        /// <summary>
        /// Ordering Customer (50H)
        /// </summary>
        public OrderingCustomer OrderingCustomer { get; set; }

        /// <summary>
        /// Requested Execution Date (30)
        /// </summary>
        public DateTime? RequestedExecutionDate { get; set; }
    }
}
