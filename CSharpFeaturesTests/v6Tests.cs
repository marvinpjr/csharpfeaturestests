using CSharpFeaturesTests.ClassesToTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static CSharpFeaturesTests.ClassesToTest.Person;

namespace CSharpFeaturesTests
{
    /// <summary>
    /// See https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6
    /// </summary>
    [TestClass]
    public class v6Tests
    {
        [TestMethod]
        public void CanUseReadOnlyAutoProperties()
        {
            var p = new Person("Marvin", "Palmer");
            // p.FirstName = "Bob"; can't do this
            Assert.AreEqual("Marvin", p.FirstName);
        }

        [TestMethod]
        public void CanUseAutoPropertyInitializers()
        {
            var p = new Person();
            Assert.AreEqual("Bob", p.FirstName);
            Assert.AreEqual("Barker", p.LastName);
        }

        [TestMethod]
        public void CanUseExpressionBodiedFunctionMembers()
        {
            var p1 = new Person("Garrett", "Palmer");
            var p2 = new Person();
            Assert.AreEqual("Joshua Garrett Palmer", p1.FullName);
            Assert.AreEqual("Bob Barker", p2.FullName);
        }
          
        [TestMethod]
        public void CanUseStaticImports()
        {
            Assert.AreEqual(12, DefaultAge);
        }

        [TestMethod]
        public void CanUseNullConditionalOperators()
        {
            Person p1 = null;
            Person p2 = new Person();
            var defaultFirst = p1?.FirstName ?? "Default First";

            Assert.AreEqual("Bob", p2?.FirstName);
            Assert.AreEqual(null, p1?.FirstName);        
        }

        [TestMethod]
        public void CanUseNullConditionalsWithNullCoalescing()
        {
            Person p1 = null;
            var defaultFirst = p1?.FirstName ?? "Default First";

            Assert.AreEqual("Default First", defaultFirst);
        }

        [TestMethod]
        public void CanUseStringInterpolation()
        {
            var p1 = new Person();
            var stringInterp = $"{p1.LastName}, {p1.FirstName}";

            Assert.AreEqual("Barker, Bob", stringInterp);
        }

        [TestMethod]
        public void CanUseExceptionFilters()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseNameOfExpression()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanUseAwaitInCatchFinally()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanInitAssociativeCollectionsUsingIndexers()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanHaveExtensionAddMethodsInCollectionInitializers()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanHaveImprovedOverloadResolution()
        {
            throw new NotImplementedException();
        }
    }
}
