using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class OrderingCustomer
    {
        /// <summary>
        /// Ordering Customer account number (50H)
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Ordering Customer: Name and address (50H).
        /// Each item in array should contains data from one line.
        /// </summary>
        public string[] NameAndAdress { get; set; }
    }
}
