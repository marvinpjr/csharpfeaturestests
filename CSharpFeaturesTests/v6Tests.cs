using CSharpFeaturesTests.ClassesToTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
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
            var p1 = new Person("Marvin", "Palmer");            

            Assert.AreEqual(true, p1.IsFirstNameExcept("Marvin"));
            Assert.AreEqual(false, p1.IsFirstNameExcept("Cody"));
        }

        [TestMethod]
        public void CanUseNameOfExpression()
        {
            var p1 = new Person();
            Assert.AreEqual("FirstName", nameof(p1.FirstName));
        }

        [TestMethod]
        public async Task CanUseAwaitInCatchFinally()
        {
            var p1 = new Person();
            var p2 = new Person("Marvin", "Palmer");

            var p1Full = await p1.GetFullNameAsync();
            var p2Full = await p2.GetFullNameAsync();

            Assert.AreEqual(0, p1.Errors.Count);
            Assert.AreEqual(1, p2.Errors.Count);
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
