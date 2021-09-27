using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTools.Model
{
    public class MT101SequenceB
    {
        /// <summary>
        /// Transaction Reference (21).
        /// </summary>
        public string TransactionReference { get; set; }

        /// <summary>
        /// Currency (32B).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Transaction amount (32B).
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// The beneficiary (59).
        /// </summary>
        public Beneficiary Beneficiary { get; set; }

        /// <summary>
        /// Remittance Information (70).
        /// Each item in array should contains data from one line.
        /// </summary>
        public string[] RemittanceInformation { get; set; }
    }
}
