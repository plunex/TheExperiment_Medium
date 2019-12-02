using Experiment.Procedure;
using Experiment.Sample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Experiment.UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestGetSampleType()
        {
            // Arrange 
            string expectedResult = "String";

            // Act
            var procedure = new Procedures();
            var samples = new Samples();
            var actualResult = procedure.getSampleType(samples.getSample1());

            // Check
            Assert.AreEqual (expectedResult, actualResult);
        }
    }
}
