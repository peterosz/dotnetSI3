using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializePeople;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople.Tests
{
    [TestClass]
    public class PersonTests
    {
        Person testDude;
        static string fileName = "SerializedPeople.binary";

        [TestInitialize]
        public void BeforeEachTest()
        {
            testDude = new Person("TestDude", new DateTime(1990, 1, 1), Person.Genders.Male);
        }

        [TestMethod]
        public void PersonTest_CreatedPersonExists_NameCanBeAltered()
        {
            testDude.Name = "TestDude_NewName";
            Assert.AreEqual("TestDude_NewName", testDude.Name);
        }

        [TestMethod]
        public void ToStringTest_TestIfResultIsCorrect()
        {
            Assert.AreEqual("\n Name: TestDude"+
                            "\n Age: 27"+
                            "\n Date of Birth: 1990-01-01"+
                            "\n Gender: Male", testDude.ToString());
        }

        [TestMethod]
        public void SerializeTest_CreatesAFile()
        {
            testDude.Serialize();
            Assert.AreEqual(true, File.Exists(fileName));
        }
    }
}