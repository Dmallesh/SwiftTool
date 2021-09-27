
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
    public class ParserStructureTest
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
            assembly = Assembly.Load(Decode("U3dpZnRUb29scy5QYXJzZXIsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxs") /*"SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVQxMDFQYXJzZXI=") /*"MT101Parser"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("VmFsaWRhdGVGb3JtYXQ=") /*"ValidateFormat"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.ValidateFormat(Stream content) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.ValidateFormat(Stream content) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.ValidateFormat(Stream content) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.ValidateFormat(Stream content) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29udGVudA==") /*"content"*/  && x.ParameterType.FullName == "System.IO.Stream");
                                Assert.IsNotNull(parameter, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.ValidateFormat(Stream content) parameter content does not exists or does not have type System.IO.Stream");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UGFyc2U=") /*"Parse"*/ );                            Assert.IsNotNull(method, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.Parse(Stream content) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.Parse(Stream content) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("SwiftTools.Model.MT101Message[]",methodReturnType.FullName, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.Parse(Stream content) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.Parse(Stream content) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29udGVudA==") /*"content"*/  && x.ParameterType.FullName == "System.IO.Stream");
                                Assert.IsNotNull(parameter, "method: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser.Parse(Stream content) parameter content does not exists or does not have type System.IO.Stream");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.MT101Parser.MT101Parser() does not exists");


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
