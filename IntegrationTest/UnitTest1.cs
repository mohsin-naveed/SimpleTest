
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTest;
using TextABCReader;
using TextABCReader.Interfaces;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest1()
        {

            ITextTransformer textTransformer = new TextTransformer();
            ILogger logger = new ConsoleLogger();

            var myTest = new MyTest(textTransformer, logger);


            Assert.AreEqual("baby Go go", myTest.TransformText("Go baby, go"));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            ITextTransformer textTransformer = new TextTransformer();
            ILogger logger = new ConsoleLogger();

            var myTest = new MyTest(textTransformer, logger);

            Assert.AreEqual("ABC aBc abc CBA CBA cba", myTest.TransformText("CBA, abc aBc ABC cba CBA."));
        }
    }
}