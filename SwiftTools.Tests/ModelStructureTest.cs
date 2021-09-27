
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
    public class ModelStructureTest
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
            assembly = Assembly.Load(Decode("U3dpZnRUb29scy5Nb2RlbCwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=") /*"SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmVuZWZpY2lhcnk=") /*"Beneficiary"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QWNjb3VudA==") /*"Account"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.String Account does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnQ=") /*"get_Account"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnQ=") /*"get_Account"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_Account() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.String Account  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TmFtZUFuZEFkcmVzcw==") /*"NameAndAdress"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.String[] NameAndAdress does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWVBbmRBZHJlc3M=") /*"get_NameAndAdress"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWVBbmRBZHJlc3M=") /*"get_NameAndAdress"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.get_NameAndAdress() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.Beneficiary.String[] NameAndAdress  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("RW1wdHlMaW5lc0V4Y2VwdGlvbg==") /*"EmptyLinesException"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.Int32[]");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException(Int32[] incorrectLines) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException(Int32[] incorrectLines)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("aW5jb3JyZWN0TGluZXM=") /*"incorrectLines"*/  && x.ParameterType.FullName == "System.Int32[]");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException(Int32[] incorrectLines) parameter incorrectLines does not exists or does not have type System.Int32[]");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0TGluZXM=") /*"IncorrectLines"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.Int32[] IncorrectLines does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdExpbmVz") /*"get_IncorrectLines"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdExpbmVz") /*"get_IncorrectLines"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.get_IncorrectLines() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.EmptyLinesException.Int32[] IncorrectLines  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0Q2hhcg==") /*"IncorrectChar"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SW5kZXg=") /*"Index"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.Int32 Index does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luZGV4") /*"get_Index"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luZGV4") /*"get_Index"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_Index() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.Int32 Index  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0Q2hhcmFjdGVy") /*"IncorrectCharacter"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.Char IncorrectCharacter does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdENoYXJhY3Rlcg==") /*"get_IncorrectCharacter"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Char",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdENoYXJhY3Rlcg==") /*"get_IncorrectCharacter"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Char",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.get_IncorrectCharacter() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Char",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectChar.Char IncorrectCharacter  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0TGluZXNFeGNlcHRpb24=") /*"IncorrectLinesException"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.Int32[]");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException(Int32[] incorrectLines) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException(Int32[] incorrectLines)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("aW5jb3JyZWN0TGluZXM=") /*"incorrectLines"*/  && x.ParameterType.FullName == "System.Int32[]");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException(Int32[] incorrectLines) parameter incorrectLines does not exists or does not have type System.Int32[]");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0TGluZXM=") /*"IncorrectLines"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.Int32[] IncorrectLines does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdExpbmVz") /*"get_IncorrectLines"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdExpbmVz") /*"get_IncorrectLines"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.get_IncorrectLines() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.IncorrectLinesException.Int32[] IncorrectLines  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVQxMDFNZXNzYWdl") /*"MT101Message"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2VxdWVuY2VB") /*"SequenceA"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.MT101SequenceA SequenceA does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlcXVlbmNlQQ==") /*"get_SequenceA"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101SequenceA",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlcXVlbmNlQQ==") /*"get_SequenceA"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101SequenceA",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceA() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.MT101SequenceA",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.MT101SequenceA SequenceA  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2VxdWVuY2VC") /*"SequenceB"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.MT101SequenceB[] SequenceB does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlcXVlbmNlQg==") /*"get_SequenceB"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101SequenceB[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlcXVlbmNlQg==") /*"get_SequenceB"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.MT101SequenceB[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_SequenceB() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.MT101SequenceB[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.MT101SequenceB[] SequenceB  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmF3") /*"Raw"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.String Raw does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1Jhdw==") /*"get_Raw"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1Jhdw==") /*"get_Raw"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Raw() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.String Raw  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RXJyb3Jz") /*"Errors"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.TagError[] Errors does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Vycm9ycw==") /*"get_Errors"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.TagError[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Vycm9ycw==") /*"get_Errors"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.TagError[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.get_Errors() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.TagError[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101Message.TagError[] Errors  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVQxMDFTZXF1ZW5jZUE=") /*"MT101SequenceA"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2VuZGVyUmVmZXJlbmNl") /*"SenderReference"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.String SenderReference does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbmRlclJlZmVyZW5jZQ==") /*"get_SenderReference"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NlbmRlclJlZmVyZW5jZQ==") /*"get_SenderReference"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_SenderReference() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.String SenderReference  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("T3JkZXJpbmdDdXN0b21lcg==") /*"OrderingCustomer"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.OrderingCustomer OrderingCustomer does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X09yZGVyaW5nQ3VzdG9tZXI=") /*"get_OrderingCustomer"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.OrderingCustomer",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X09yZGVyaW5nQ3VzdG9tZXI=") /*"get_OrderingCustomer"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.OrderingCustomer",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_OrderingCustomer() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.OrderingCustomer",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.OrderingCustomer OrderingCustomer  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmVxdWVzdGVkRXhlY3V0aW9uRGF0ZQ==") /*"RequestedExecutionDate"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.Nullable`1 RequestedExecutionDate does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlcXVlc3RlZEV4ZWN1dGlvbkRhdGU=") /*"get_RequestedExecutionDate"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Nullable`1[[System.DateTime, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlcXVlc3RlZEV4ZWN1dGlvbkRhdGU=") /*"get_RequestedExecutionDate"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Nullable`1[[System.DateTime, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.get_RequestedExecutionDate() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Nullable`1[[System.DateTime, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceA.Nullable`1 RequestedExecutionDate  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVQxMDFTZXF1ZW5jZUI=") /*"MT101SequenceB"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VHJhbnNhY3Rpb25SZWZlcmVuY2U=") /*"TransactionReference"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String TransactionReference does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uUmVmZXJlbmNl") /*"get_TransactionReference"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uUmVmZXJlbmNl") /*"get_TransactionReference"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_TransactionReference() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String TransactionReference  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q3VycmVuY3k=") /*"Currency"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String Currency does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0N1cnJlbmN5") /*"get_Currency"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0N1cnJlbmN5") /*"get_Currency"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Currency() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String Currency  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QW1vdW50") /*"Amount"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.Nullable`1 Amount does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Nullable`1[[System.Decimal, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Nullable`1[[System.Decimal, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Amount() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Nullable`1[[System.Decimal, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.Nullable`1 Amount  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QmVuZWZpY2lhcnk=") /*"Beneficiary"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.Beneficiary Beneficiary does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JlbmVmaWNpYXJ5") /*"get_Beneficiary"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.Beneficiary",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JlbmVmaWNpYXJ5") /*"get_Beneficiary"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.Beneficiary",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_Beneficiary() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.Beneficiary",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.Beneficiary Beneficiary  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmVtaXR0YW5jZUluZm9ybWF0aW9u") /*"RemittanceInformation"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String[] RemittanceInformation does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlbWl0dGFuY2VJbmZvcm1hdGlvbg==") /*"get_RemittanceInformation"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlbWl0dGFuY2VJbmZvcm1hdGlvbg==") /*"get_RemittanceInformation"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.get_RemittanceInformation() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MT101SequenceB.String[] RemittanceInformation  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("TVRGb3JtYXRFeGNlcHRpb24=") /*"MTFormatException"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MTFormatException");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MTFormatException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MTFormatException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.MTFormatException() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Tm9EYXRhRXhjZXB0aW9u") /*"NoDataException"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NoDataException");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NoDataException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NoDataException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NoDataException() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Tm90QWxsb3dlZENoYXJhY3RlcnNFeGNlcHRpb24=") /*"NotAllowedCharactersException"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("SwiftTools.Model.IncorrectChar[]");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException(IncorrectChar[] incorrectChars) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException(IncorrectChar[] incorrectChars)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("aW5jb3JyZWN0Q2hhcnM=") /*"incorrectChars"*/  && x.ParameterType.FullName == "SwiftTools.Model.IncorrectChar[]");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException(IncorrectChar[] incorrectChars) parameter incorrectChars does not exists or does not have type SwiftTools.Model.IncorrectChar[]");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SW5jb3JyZWN0Q2hhcnM=") /*"IncorrectChars"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.IncorrectChar[] IncorrectChars does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdENoYXJz") /*"get_IncorrectChars"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.IncorrectChar[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0luY29ycmVjdENoYXJz") /*"get_IncorrectChars"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.IncorrectChar[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.get_IncorrectChars() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.IncorrectChar[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.NotAllowedCharactersException.IncorrectChar[] IncorrectChars  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("T3JkZXJpbmdDdXN0b21lcg==") /*"OrderingCustomer"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QWNjb3VudA==") /*"Account"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.String Account does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnQ=") /*"get_Account"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnQ=") /*"get_Account"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_Account() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.String Account  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TmFtZUFuZEFkcmVzcw==") /*"NameAndAdress"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.String[] NameAndAdress does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWVBbmRBZHJlc3M=") /*"get_NameAndAdress"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X05hbWVBbmRBZHJlc3M=") /*"get_NameAndAdress"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String[]",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.get_NameAndAdress() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String[]",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.OrderingCustomer.String[] NameAndAdress  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("VGFnRXJyb3I=") /*"TagError"*/ );
                Assert.IsNotNull(type, "Missing assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError");
                    Assert.IsTrue(type.IsClass, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("System.String");
                            constructorParameterNameTypeDictionary.Add("System.String");
                            constructorParameterNameTypeDictionary.Add("SwiftTools.Model.TagError+TagErrorType");
                            constructorParameterNameTypeDictionary.Add("System.Int32");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("dGFn") /*"tag"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB) parameter tag does not exists or does not have type System.String");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("dmFsdWU=") /*"value"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB) parameter value does not exists or does not have type System.String");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZXJyb3JUeXBl") /*"errorType"*/  && x.ParameterType.FullName == "SwiftTools.Model.TagError+TagErrorType");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB) parameter errorType does not exists or does not have type SwiftTools.Model.TagError+TagErrorType");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(4,parametersCount, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("bnVtYmVyT2ZTZXF1ZW5jZUI=") /*"numberOfSequenceB"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "constructor: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError(String tagString valueTagErrorType errorTypeInt32 numberOfSequenceB) parameter numberOfSequenceB does not exists or does not have type System.Int32");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VGFn") /*"Tag"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.String Tag does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RhZw==") /*"get_Tag"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RhZw==") /*"get_Tag"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Tag() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.String Tag  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VmFsdWU=") /*"Value"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.String Value does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1ZhbHVl") /*"get_Value"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1ZhbHVl") /*"get_Value"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_Value() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.String Value  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RXJyb3JUeXBl") /*"ErrorType"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.TagErrorType ErrorType does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Vycm9yVHlwZQ==") /*"get_ErrorType"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.TagError+TagErrorType",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Vycm9yVHlwZQ==") /*"get_ErrorType"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("SwiftTools.Model.TagError+TagErrorType",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_ErrorType() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("SwiftTools.Model.TagError+TagErrorType",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.TagErrorType ErrorType  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TnVtYmVyT2ZTZXF1ZW5jZUI=") /*"NumberOfSequenceB"*/ );
                            Assert.IsNotNull(property, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.Int32 NumberOfSequenceB does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mU2VxdWVuY2VC") /*"get_NumberOfSequenceB"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X051bWJlck9mU2VxdWVuY2VC") /*"get_NumberOfSequenceB"*/ );                                Assert.IsNotNull(method, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.get_NumberOfSequenceB() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: SwiftTools.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:SwiftTools.Model.TagError.Int32 NumberOfSequenceB  type has changed");


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
