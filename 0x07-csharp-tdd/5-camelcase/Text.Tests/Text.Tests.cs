using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CamelCase_Empty()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CamelCase_Single()
        {
            string test = "wao";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void CamelCase_Words()
        {
            //string test = "iThoughtWhatIdDoWasIdPretendIWasOneOfThoseDeafMutes";
            string test = "wowWow";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void CamelCase_Null()
        {
            string test = null;
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
