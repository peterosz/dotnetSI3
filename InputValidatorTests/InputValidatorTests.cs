using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidatorForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidatorForm.Tests
{
    [TestClass]
    public class InputValidatorTests
    {
        InputValidatorLogic validator;

        [TestInitialize]
        public void InitializeTests()
        {
            validator = new InputValidatorLogic();
        }

        [TestMethod]
        public void ValidEmailTest_ValidEmail_ReturnsTrue()
        {
            var result = validator.ValidEmail("averagejoe@gmail.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidEmailTest_InvalidEmail_ReturnsFalse()
        {
            var result = validator.ValidEmail("joe.com");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ValidPhoneNumberTest_ValidPhoneNumber_ReturnsTrue()
        {
            var result = validator.ValidPhoneNumber("+36 30 979 0923");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidPhoneNumberTest_BellsPhoneNumber_ReturnsFalse()
        {
            var result = validator.ValidPhoneNumber("1");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ValidNameTest_RegularName_ReturnsTrue()
        {
            var result = validator.ValidName("Average Joe");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidNameTest_Numbers_ReturnsFalse()
        {
            var result = validator.ValidName("77");
            Assert.AreEqual(false, result);
        }
    }
}