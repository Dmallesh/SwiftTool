
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace SwiftTools.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class WebStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("U3dpZnRUb29scy5XZWJBcGksIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxs") /*"SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("UHJvZ3JhbQ==") /*"Program"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("TWFpbg==") /*"Main"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.Main(String[] args) parameter args does not exists or does not have type System.String[]");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlV2ViSG9zdEJ1aWxkZXI=") /*"CreateWebHostBuilder"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Hosting.IWebHostBuilder",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program.CreateWebHostBuilder(String[] args) parameter args does not exists or does not have type System.String[]");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Program() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3RhcnR1cA==") /*"Startup"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJlU2VydmljZXM=") /*"ConfigureServices"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.ConfigureServices(IServiceCollection services) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.ConfigureServices(IServiceCollection services) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.ConfigureServices(IServiceCollection services) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.ConfigureServices(IServiceCollection services) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZXM=") /*"services"*/  && x.ParameterType.FullName == "Microsoft.Extensions.DependencyInjection.IServiceCollection");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.ConfigureServices(IServiceCollection services) parameter services does not exists or does not have type Microsoft.Extensions.DependencyInjection.IServiceCollection");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJl") /*"Configure"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXBw") /*"app"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter app does not exists or does not have type Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZW52") /*"env"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter env does not exists or does not have type Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup(IConfiguration configuration) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup(IConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup(IConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJhdGlvbg==") /*"Configuration"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.IConfiguration Configuration does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbmZpZ3VyYXRpb24=") /*"get_Configuration"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.get_Configuration() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.get_Configuration() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.get_Configuration() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",propertyReturnType.FullName, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Startup.IConfiguration Configuration  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVQxMDFEYXRhTW9kZWw=") /*"MT101DataModel"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q29udGVudA==") /*"Content"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.String Content does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbnRlbnQ=") /*"get_Content"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbnRlbnQ=") /*"get_Content"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.get_Content() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.MT101DataModel.String Content  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("UGFyc2luZ1Jlc3VsdA==") /*"ParsingResult"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TVQxMDE=") /*"MT101"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.MT101Message[] MT101 does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X01UMTAx") /*"get_MT101"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101Message[]",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X01UMTAx") /*"get_MT101"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101Message[]",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.get_MT101() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.MT101Message[]",propertyReturnType.FullName, "property: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.ViewModel.ParsingResult.MT101Message[] MT101  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3dpZnRUb29sc0FwaUNvbnRyb2xsZXI=") /*"SwiftToolsApiController"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("VmFsaWRhdGVNVDEwMUNvbnRlbnQ=") /*"ValidateMT101Content"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ValidateMT101Content(MT101DataModel data) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ValidateMT101Content(MT101DataModel data) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ValidateMT101Content(MT101DataModel data) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ValidateMT101Content(MT101DataModel data) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZGF0YQ==") /*"data"*/  && x.ParameterType.FullName == "SwiftTools.WebApi.ViewModel.MT101DataModel");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ValidateMT101Content(MT101DataModel data) parameter data does not exists or does not have type SwiftTools.WebApi.ViewModel.MT101DataModel");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UGFyc2VNVDEwMUNvbnRlbnQ=") /*"ParseMT101Content"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ParseMT101Content(MT101DataModel data) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ParseMT101Content(MT101DataModel data) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("SwiftTools.WebApi.ViewModel.ParsingResult",methodReturnType.FullName, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ParseMT101Content(MT101DataModel data) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ParseMT101Content(MT101DataModel data) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZGF0YQ==") /*"data"*/  && x.ParameterType.FullName == "SwiftTools.WebApi.ViewModel.MT101DataModel");
                                Assert.IsNotNull(parameter, "method: SwiftTools.WebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.WebApi.Controllers.SwiftToolsApiController.ParseMT101Content(MT101DataModel data) parameter data does not exists or does not have type SwiftTools.WebApi.ViewModel.MT101DataModel");
                        constructorParameterNameTypeDictionary = new List<string>();


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
