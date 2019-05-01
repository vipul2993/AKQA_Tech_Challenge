using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Services.Interface;

namespace Challenge.Tests
{
    [TestClass]
    public class ConvertorTest
    {
        private IChallenge challengeService;

        public ConvertorTest()
        {
            challengeService = new ChallengeService();
        }

        [TestMethod]
        public void IsNotValidNumber()
        {
            Assert.AreEqual("Not Valid Number", challengeService.ConvertToWords("AB123"));
        }

        [TestMethod]
        public void IsValidNumber()
        {
            string result = challengeService.ConvertToWords("123");
            Assert.AreEqual("One Hundred Twenty Three  Only", result);
        }
    }
}
