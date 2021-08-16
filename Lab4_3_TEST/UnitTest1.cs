using System;
using Xunit;
using DebuildLab_4_3;

namespace Lab4_3_TEST
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)] //pass
        [InlineData(2, 3)] //pass
        [InlineData(4, 7)] //pass
        [InlineData(5, 23)] //fail (intentional)
        [InlineData(7, 98)] //fail (intentional)

        public void TestIsPrime(int num, int expected)
        {
            int result = Program.PrimeNumber.GetPrime(num);
            Assert.Equal(expected, result);
        }

    }
}
