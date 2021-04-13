using System;
using Xunit;
using PrimeTDD;

namespace PrimeTDD_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 29)]
        [InlineData(1, 2)]
        [InlineData(3, 5)]
        [InlineData(7, 17)]
        [InlineData(14, 43)]
        [InlineData(1000, 7919)]
        
        public void GetPrimeTest1(int input, int expected)
        {

            PrimeNumbers prime = new PrimeNumbers();
            int result = prime.GetPrime(input);
            Assert.Equal(expected, result);

        }
    }
}
