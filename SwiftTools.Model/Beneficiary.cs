using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class Beneficiary
    {
        /// <summary>
        /// The beneficiary account number (59).
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The beneficiary name and address (59).
        /// Each item in array should contains data from one line.
        /// </summary>
        public string[] NameAndAdress { get; set; }

    }
}
