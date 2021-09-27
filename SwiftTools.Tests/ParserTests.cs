using NUnit.Framework;
using SwiftTools.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SwiftTools.Tests
{
    public class ParserTests
    {
        [Test]
        public void Validate_NullContent_Test()
        {
            Assert.Throws<NoDataException>(() => new MT101Parser.MT101Parser().ValidateFormat(null));
        }

        [Test]
        public void Validate_EmptyStream_Test()
        {
            Assert.Throws<  >(() => new MT101Parser.MT101Parser().ValidateFormat(new MemoryStream()));
        }

        [Test]
        public void Validate_CorrectFormat_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}{4:\r\n-}{5:}");
                stream.Write(data, 0, data.Length);
                new MT101Parser.MT101Parser().ValidateFormat(stream);
            }
        }

        [Test]
        public void Validate_CorrectFormatOnlyBlock4_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{4:\r\n-}");
                stream.Write(data, 0, data.Length);
                new MT101Parser.MT101Parser().ValidateFormat(stream);
            }
        }

        [Test]
        public void Validate_IncorrectCharacters_Test()
        {
            using (var stream = new MemoryStream())
            {
                try
                { 
                var data = UTF8Encoding.UTF8.GetBytes("\t{1:*}{2:}{3:}{4:\r\n-}{5:}");
                stream.Write(data, 0, data.Length);
                new MT101Parser.MT101Parser().ValidateFormat(stream);
                    Assert.Fail($"{nameof(NotAllowedCharactersException)} expected!");
                }
                catch (NotAllowedCharactersException ex)
                {
                    Assert.IsNotNull(ex.IncorrectChars);
                    Assert.AreEqual(2, ex.IncorrectChars.Length);
                    Assert.AreEqual(1, ex.IncorrectChars[0].Index); // first character
                    Assert.AreEqual('\t', ex.IncorrectChars[0].IncorrectCharacter); 
                    Assert.AreEqual(5, ex.IncorrectChars[1].Index);       // fifth character
                    Assert.AreEqual('*', ex.IncorrectChars[1].IncorrectCharacter);      
                }
                catch (Exception)
                {
                    Assert.Fail($"{nameof(NotAllowedCharactersException)} expected!");
                }
            }
        }

        [Test]
        public void Validate_NoBlock4_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}{5:}");
                stream.Write(data, 0, data.Length);
                Assert.Throws<MTFormatException>(() => new MT101Parser.MT101Parser().ValidateFormat(stream));                
            }
        }

        [Test]
        public void Validate_EmptyLines_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}\r\n\r\n{2:}{3:}{4:\r\n-}\r\n\r\n{5:}");
                stream.Write(data, 0, data.Length);
                try
                {
                    new MT101Parser.MT101Parser().ValidateFormat(stream);
                    Assert.Fail($"{nameof(EmptyLinesException)} expected!");
                }
                catch(EmptyLinesException ex)
                {
                    Assert.IsNotNull(ex.IncorrectLines);
                    Assert.AreEqual(2, ex.IncorrectLines.Length);
                    Assert.AreEqual(2, ex.IncorrectLines[0]); // line no 2
                    Assert.AreEqual(5, ex.IncorrectLines[1]); // line no 5
                }
                catch(Exception)
                {
                    Assert.Fail($"{nameof(EmptyLinesException)} expected!");
                }
            }
        }

        [Test]
        public void Validate_IncorrectLines_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}\r\n-\r\n{2:}{3:}{4:\r\n-data\r\n-\r\n-}{5:}");
                stream.Write(data, 0, data.Length);
                try
                {
                    new MT101Parser.MT101Parser().ValidateFormat(stream);
                    Assert.Fail($"{nameof(IncorrectLinesException)} expected!");
                }
                catch (IncorrectLinesException ex)
                {
                    Assert.IsNotNull(ex.IncorrectLines);
                    Assert.AreEqual(3, ex.IncorrectLines.Length);
                    Assert.AreEqual(2, ex.IncorrectLines[0]); // line no 2
                    Assert.AreEqual(4, ex.IncorrectLines[1]); // line no 4
                    Assert.AreEqual(5, ex.IncorrectLines[2]); // line no 5
                }
                catch (Exception)
                {
                    Assert.Fail($"{nameof(IncorrectLinesException)} expected!");
                }
            }
        }

        /// <summary>
        /// There is no "-}" in block 4
        /// </summary>
        [Test]
        public void Validate_IncorrectEndBlock4_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}{4:\r\n{5:}");
                stream.Write(data, 0, data.Length);
                Assert.Throws<MTFormatException>(() => new MT101Parser.MT101Parser().ValidateFormat(stream));
            }
        }

        [Test]
        public void Validate_IncorrectBlock4_CurlyBracketsInside_Test()
        {
            using (var stream = new MemoryStream())
            {
                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}{4:{}\r\n-}{5:}");
                stream.Write(data, 0, data.Length);
                Assert.Throws<MTFormatException>(() => new MT101Parser.MT101Parser().ValidateFormat(stream));
            }
        }

        [Test]
        public void Parse_CorrectSingleWith_2_Transactions_Test()
        {
            using (var stream = new MemoryStream())
            {
                var block4 = "{4:\r\n:20:1106210100000003\r\n:28D:1/2\r\n:50H:/PL64114010100000123456001001\r\nORDERING CUSTOMER NAME1\r\nORDERING CUSTOMER NAME2\r\nSTREET\r\n"+
                    "CITY\r\n:52A:BREXPLPWXXX\r\n:30:110621\r\n:21:2011062100000003\r\n:32B:EUR955,55\r\n:57A:CITIGB1LXXX\r\n:59:/IT40S0542811101000000123456\r\nBENEFICAIRY NAME 1\r\nBENEFICIARY NAME 2\r\n"+
                    "STREET\r\nCITY\r\n:70:INVOICE 11/06/06\r\n:71A:SHA\r\n:21:2011062100000004\r\n:32B:EUR100,12\r\n:57A:CITIGB2LXXX\r\n:59:/IT40S054281110100000098765\r\nBENEFICAIRY ABC NAME 1\r\n"+
                    "BENEFICIARY ABC NAME 2\r\nSTREET 2\r\nCITY 2\r\n:70:INVOICE 12/06/06\r\n:71A:SHA\r\n-}";

                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}"+ block4 + "{5:}");
                stream.Write(data, 0, data.Length);
                var allMt101 = new MT101Parser.MT101Parser().Parse(stream);
                Assert.AreEqual(1, allMt101.Length);

                var mt101 = allMt101[0];
                Assert.AreEqual(block4, mt101.Raw);
                Assert.AreEqual("1106210100000003", mt101.SequenceA.SenderReference);
                Assert.AreEqual(new DateTime(2011, 06, 21), mt101.SequenceA.RequestedExecutionDate);
                Assert.AreEqual("PL64114010100000123456001001", mt101.SequenceA.OrderingCustomer.Account);
                Assert.AreEqual("ORDERING CUSTOMER NAME1\r\nORDERING CUSTOMER NAME2\r\nSTREET\r\nCITY", string.Join("\r\n", mt101.SequenceA.OrderingCustomer.NameAndAdress));

                Assert.AreEqual(2, mt101.SequenceB.Length);

                var first = mt101.SequenceB[0];
                var second = mt101.SequenceB[1];

                Assert.AreEqual(955.55m, first.Amount);
                Assert.AreEqual("EUR", first.Currency);
                Assert.AreEqual("IT40S0542811101000000123456", first.Beneficiary.Account);
                Assert.AreEqual("BENEFICAIRY NAME 1\r\nBENEFICIARY NAME 2\r\nSTREET\r\nCITY", string.Join("\r\n", first.Beneficiary.NameAndAdress));
                Assert.AreEqual("INVOICE 11/06/06", string.Join("\r\n", first.RemittanceInformation));
                Assert.AreEqual("2011062100000003", first.TransactionReference);

                Assert.AreEqual(100.12m, second.Amount);
                Assert.AreEqual("EUR", second.Currency);
                Assert.AreEqual("IT40S054281110100000098765", second.Beneficiary.Account);
                Assert.AreEqual("BENEFICAIRY ABC NAME 1\r\nBENEFICIARY ABC NAME 2\r\nSTREET 2\r\nCITY 2", string.Join("\r\n", second.Beneficiary.NameAndAdress));
                Assert.AreEqual("INVOICE 12/06/06", string.Join("\r\n", second.RemittanceInformation));
                Assert.AreEqual("2011062100000004", second.TransactionReference);

                Assert.IsTrue(mt101.Errors == null || mt101.Errors.Length == 0);
            }
        }

        [Test]
        public void Parse_SingleWith_2_Transactions_IncorrectValues_Test()
        {
            using (var stream = new MemoryStream())
            {
                var block4 = "{4:\r\n:20:1106210100000003\r\n:28D:1/2\r\n:50H:/PL64114010100000123456001001\r\nORDERING CUSTOMER NAME1\r\nORDERING CUSTOMER NAME2\r\n"+
                    "STREET\r\nCITY\r\n:52A:BREXPLPWXXX\r\n:30:ABCD\r\n:21:2011062100000003\r\n:32B:EUR955,55\r\n:57A:CITIGB1LXXX\r\n:59:/IT40S0542811101000000123456\r\nBENEFICAIRY NAME 1\r\n"+
                    "BENEFICIARY NAME 2\r\nSTREET\r\nCITY\r\n:70:INVOICE 11/06/06\r\n:71A:abcd2\r\n:21:2011062100000004000000000\r\n:32B:EUR100,12\r\n:57A:CITIGB2LXXX\r\n:59:/IT40S054281110100000098765\r\n" +
                    "BENEFICAIRY ABC NAME 1\r\nBENEFICIARY ABC NAME 2\r\nSTREET 2\r\nCITY 2\r\n:70:INVOICE 12/06/06\r\n:71A:abcd3\r\n-}";

                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}" + block4 + "{5:}");
                stream.Write(data, 0, data.Length);
                var allMt101 = new MT101Parser.MT101Parser().Parse(stream);
                Assert.AreEqual(1, allMt101.Length);

                var mt101 = allMt101[0];
                Assert.AreEqual(block4, mt101.Raw);
                Assert.AreEqual("1106210100000003", mt101.SequenceA.SenderReference);
                Assert.IsNull(mt101.SequenceA.RequestedExecutionDate);
                Assert.AreEqual("PL64114010100000123456001001", mt101.SequenceA.OrderingCustomer.Account);
                Assert.AreEqual("ORDERING CUSTOMER NAME1\r\nORDERING CUSTOMER NAME2\r\nSTREET\r\nCITY", string.Join("\r\n", mt101.SequenceA.OrderingCustomer.NameAndAdress));

                Assert.AreEqual(2, mt101.SequenceB.Length);

                var first = mt101.SequenceB[0];
                var second = mt101.SequenceB[1];

                Assert.AreEqual(955.55m, first.Amount);
                Assert.AreEqual("EUR", first.Currency);
                Assert.AreEqual("IT40S0542811101000000123456", first.Beneficiary.Account);
                Assert.AreEqual("BENEFICAIRY NAME 1\r\nBENEFICIARY NAME 2\r\nSTREET\r\nCITY", string.Join("\r\n", first.Beneficiary.NameAndAdress));
                Assert.AreEqual("INVOICE 11/06/06", string.Join("\r\n", first.RemittanceInformation));
                Assert.AreEqual("2011062100000003", first.TransactionReference);

                Assert.AreEqual(100.12m, second.Amount);
                Assert.AreEqual("EUR", second.Currency);
                Assert.AreEqual("IT40S054281110100000098765", second.Beneficiary.Account);
                Assert.AreEqual("BENEFICAIRY ABC NAME 1\r\nBENEFICIARY ABC NAME 2\r\nSTREET 2\r\nCITY 2", string.Join("\r\n", second.Beneficiary.NameAndAdress));
                Assert.AreEqual("INVOICE 12/06/06", string.Join("\r\n", second.RemittanceInformation));
                Assert.IsNull(second.TransactionReference);

                Assert.AreEqual(2, mt101.Errors.Length);
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":30:" && a.Value == "ABCD" && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":21:" && a.Value == "2011062100000004000000000" && a.NumberOfSequenceB == 2));
            }
        }

        [Test]
        public void Parse_SingleWith_2_Transactions_AllIncorrectValues_Test()
        {
            using (var stream = new MemoryStream())
            {
                var block4 = "{4:\r\n:20:\r\n:28D:\r\n:50H:\r\n:52A:\r\n:30:\r\n:21:\r\n:32B:\r\n:57A:\r\n:59:\r\n:70:\r\n:71A:\r\n:21:\r\n:32B:\r\n:57A:\r\n:59:\r\n:70:\r\n:71A:\r\n-}";

                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}" + block4 + "{5:}");
                stream.Write(data, 0, data.Length);
                var allMt101 = new MT101Parser.MT101Parser().Parse(stream);
                Assert.AreEqual(1, allMt101.Length);

                var mt101 = allMt101[0];
                Assert.AreEqual(block4, mt101.Raw);
                Assert.IsNull(mt101.SequenceA.SenderReference);
                Assert.IsNull(mt101.SequenceA.RequestedExecutionDate);
                Assert.IsTrue(mt101.SequenceA.OrderingCustomer == null);
                Assert.AreEqual(2, mt101.SequenceB.Length);

                var first = mt101.SequenceB[0];
                var second = mt101.SequenceB[1];


                Assert.IsNull(first.Currency);
                Assert.IsNull(first.Beneficiary);
                Assert.IsNull(first.RemittanceInformation);
                Assert.IsNull(first.TransactionReference);

                Assert.IsNull(second.Currency);
                Assert.IsNull(second.Beneficiary);
                Assert.IsNull(second.RemittanceInformation);
                Assert.IsNull(second.TransactionReference);

                Assert.AreEqual(9, mt101.Errors.Length);
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":20:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":30:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":50H:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":21:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":32B:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":59:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":21:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 2));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":32B:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 2));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":59:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 2));
            }
        }

        [Test]
        public void Parse_SingleWith_2_Transactions_TagNotExists_Test()
        {
            using (var stream = new MemoryStream())
            {
                var block4 ="{4:\r\n:28D:\r\n:50H:\r\n:52A:\r\n:30:\r\n:21:\r\n:57A:\r\n:59:\r\n:70:\r\n:71A:\r\n:21:\r\n:57A:\r\n:59:\r\n:70:\r\n:71A:\r\n-}";

                var data = UTF8Encoding.UTF8.GetBytes("{1:}{2:}{3:}" + block4 + "{5:}");
                stream.Write(data, 0, data.Length);
                var allMt101 = new MT101Parser.MT101Parser().Parse(stream);
                Assert.AreEqual(1, allMt101.Length);

                var mt101 = allMt101[0];
                Assert.AreEqual(block4, mt101.Raw);
                Assert.IsNull(mt101.SequenceA.SenderReference);
                Assert.IsNull(mt101.SequenceA.RequestedExecutionDate);
                Assert.IsNull(mt101.SequenceA.OrderingCustomer);
                Assert.AreEqual(2, mt101.SequenceB.Length);

                var first = mt101.SequenceB[0];
                var second = mt101.SequenceB[1];

                Assert.IsNull(first.Currency);
                Assert.IsNull(first.Beneficiary);
                Assert.IsNull(first.RemittanceInformation);
                Assert.IsNull(first.TransactionReference);

                Assert.IsNull(second.Currency);
                Assert.IsNull(second.Beneficiary);
                Assert.IsNull(second.RemittanceInformation);
                Assert.IsNull(second.TransactionReference);

                Assert.AreEqual(9, mt101.Errors.Length);
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":20:" && a.ErrorType == TagError.TagErrorType.MandatoryTagNotExists && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":30:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":50H:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 0));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":21:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":32B:" && a.ErrorType == TagError.TagErrorType.MandatoryTagNotExists && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":59:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 1));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":21:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 2));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":32B:" && a.ErrorType == TagError.TagErrorType.MandatoryTagNotExists && a.NumberOfSequenceB == 2));
                Assert.IsTrue(mt101.Errors.Any(a => a.Tag == ":59:" && a.ErrorType == TagError.TagErrorType.IncorrectTagValue && a.NumberOfSequenceB == 2));
            }
        }
    }
}
