using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using SwiftTools.WebApi;
using SwiftTools.WebApi.ViewModel;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwiftTools.Tests
{
    public class WebApiTests
    {
        private StringContent GetJsonContent(string content)
        {
            var json = JsonConvert.SerializeObject(new MT101DataModel() { Content = content });
            return new StringContent(json, UTF8Encoding.UTF8, "application/json");
        }

        [Test]
        public async Task ValidateMT101_Correct_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.PostAsync("/api/swift/validate-format-mt101", GetJsonContent("{1:}{2:}{3:}{4:\r\n-}{5:}}"));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("0", data);
        }

        [Test]
        public async Task ValidateMT101_EmptyContent_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.PostAsync("/api/swift/validate-format-mt101", GetJsonContent(""));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("1", data);
        }

        [Test]
        public async Task ValidateMT101_IncorrectBlock4_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.PostAsync("/api/swift/validate-format-mt101", GetJsonContent("{4: { -}"));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("2", data);
        }

        [Test]
        public async Task ValidateMT101_EmptyLine_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.PostAsync("/api/swift/validate-format-mt101", GetJsonContent("{1:}{2:}{3:}{4:\r\n\r\n\r\n-}{5:}}"));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("3", data);
        }

        [Test]
        public async Task ValidateMT101_IncorrectLines_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.PostAsync("/api/swift/validate-format-mt101", GetJsonContent("{1:}{2:}{3:}{4:\r\n-\r\n-}{5:}}"));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("4", data);
        }

        [Test]
        public async Task ParseMT101_Correct_Test()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();

            var block4 = "{4:\r\n" +
                ":20:1106210100000003\r\n" +
                ":28D:1/2\r\n" +
                ":50H:/PL64114010100000123456001001\r\n" +
                "ORDERING CUSTOMER NAME1\r\n" +
                "ORDERING CUSTOMER NAME2\r\n" +
                "STREET\r\n" +
                "CITY\r\n" +
                ":52A:BREXPLPWXXX\r\n" +
                ":30:110621\r\n" +
                ":21:2011062100000003\r\n" +
                ":32B:EUR955,55\r\n" +
                ":57A:CITIGB1LXXX\r\n" +
                ":59:/IT40S0542811101000000123456\r\n" +
                "BENEFICAIRY NAME 1\r\n" +
                "BENEFICIARY NAME 2\r\n" +
                "STREET\r\n" +
                "CITY\r\n" +
                ":70:INVOICE 11/06/06\r\n" +
                ":71A:SHA\r\n" +
                ":21:2011062100000004\r\n" +
                ":32B:EUR100,12\r\n" +
                ":57A:CITIGB2LXXX\r\n" +
                ":59:/IT40S054281110100000098765\r\n" +
                "BENEFICAIRY ABC NAME 1\r\n" +
                "BENEFICIARY ABC NAME 2\r\n" +
                "STREET 2\r\n" +
                "CITY 2\r\n" +
                ":70:INVOICE 12/06/06\r\n" +
                ":71A:SHA\r\n" +
                "-}";

            var mt101data = "{1:}{2:}{3:}" + block4 + "{5:}";
                               
            var result = await Client.PostAsync("/api/swift/parse-mt101", GetJsonContent(mt101data));
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();

            Assert.IsTrue(!string.IsNullOrEmpty(data));

            var mt101Result = (WebApi.ViewModel.ParsingResult)JsonConvert.DeserializeObject(data, typeof(WebApi.ViewModel.ParsingResult));

            Assert.IsNotNull(mt101Result);
            Assert.IsNotNull(mt101Result.MT101);
            Assert.AreEqual(1, mt101Result.MT101.Length);

            var mt101 = mt101Result.MT101[0];
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
}
