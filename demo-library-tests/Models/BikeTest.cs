using System;
using UnitDemo.Library.Models;
using Xunit;

namespace UnitDemo.Library.Tests.Models
{
    public class BikeTest
    {
        private readonly Bike bikeObj;

        public BikeTest()
        {
            bikeObj = new Bike();
        }

        [Fact]
        public void BikePropertiesAreNotNull()
        {
            Assert.True(bikeObj.Name is not null);
            Assert.True(bikeObj.Description is not null);
        }

        [Fact]
        public void ExpectedNumberOfBikeTypes() {
            const int expected = 5;
            var actual = Enum.GetNames(typeof(BikeType)).Length;
            Assert.True(expected == actual, $"Incorrect number of types for {nameof(BikeType)}. Expected: {expected}; Actual: {actual}");
        }
    }
}