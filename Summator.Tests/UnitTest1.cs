using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            long result = Summator.Sum(new long[] { 5, 7 });

            Assert.That(result == 12);
        }
        [Test]
        public void Test_Sum_One_Positive_Number()
        { 
            long result = Summator.Sum(new long[] { 5});

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_Two_Negative_Numbers()
        { 
            long result = Summator.Sum(new long[] { -1, -2 });

            Assert.That(result == -3);
        }

        [Test]
        public void Test_Sum_EmptyArrey()
        { 
            long result = Summator.Sum(new long[] {});

            Assert.That(result == 0);
        }
        [Test]
        public void Test_BigValues()
        {
            long result = Summator.Sum(new long[] {2000000000, 2000000000, 2000000000});

            Assert.That( result == 6000000000);
        }
    }

    
}
