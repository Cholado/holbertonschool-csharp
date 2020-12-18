using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Max_Empty()
        {
            List<int> nums = new List<int>();
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(0));
        }
        [Test]
        public void Max_List()
        {
            List<int> nums = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }
    }
}
