using CSharpFeaturesTests.ClassesToTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpFeaturesTests
{
    /// <summary>
    /// See https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7
    /// </summary>
    [TestClass]
    public class v7Tests
    {
        [TestMethod]
        public void CanUseOutVariables()
        {
            var p = new Person();
            p.GetSuffixed("Jr", out string suffixed);

            Assert.AreEqual("Bob Barker, Jr", suffixed);            
        }

        [TestMethod]
        public void CanUseOutVariablesOnTryParse()
        {
            var dateString1 = "2012-11-18";
            bool canParse = DateTime.TryParse(dateString1, out DateTime parsedDate);

            Assert.AreEqual(true, canParse);
            Assert.AreEqual(2012, parsedDate.Year);

            var dateString2 = "CantParseThis";
            canParse = DateTime.TryParse(dateString2, out DateTime parseFail);

            Assert.AreEqual(false, canParse);
            Assert.AreEqual(DateTime.MinValue, parseFail);
        }

        [TestMethod]
        public void CanUseTuples()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseDiscards()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUsePatternMatching()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanRefLocalsAndReturns()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseLocalFunctions()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseMoreExpressionBodiedMembers()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanThrowExpressions()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseGeneralizedAsyncReturnTypes()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseNumericLiteralSyntaxImprovements()
        {
            throw new NotImplementedException();
        }
    }
}
