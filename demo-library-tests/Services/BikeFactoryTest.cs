using UnitDemo.Library.Models;
using UnitDemo.Library.Services;
using Xunit;

namespace UnitDemo.Library.Tests.Services
{
    public class BikeFactoryTest
    {
        private readonly IBikeFactory bikeFactory = new BikeFactory();

        [Theory]
        [InlineData(BikeType.Road, BarType.Drop, TireType.Slick)]
        [InlineData(BikeType.Gravel, BarType.Drop, TireType.Hybrid)]
        [InlineData(BikeType.Mountain, BarType.Flat, TireType.Knobby)]
        [InlineData(BikeType.Hybrid, BarType.Flat, TireType.Hybrid)]
        [InlineData(BikeType.Fat, BarType.Flat, TireType.Fat)]
        [InlineData((BikeType)5, BarType.Flat, TireType.Hybrid)]
        public void FactoryBikeAndBarTypesAreCorrect(BikeType bikeType, BarType barType, TireType tireType)
        {
            var typedBike = bikeFactory.GetBikeOfType(bikeType);
            Assert.Equal(typedBike.Handlebars, barType);
            Assert.Equal(typedBike.Tires, tireType);
            Assert.Equal(typedBike.Description, bikeType.ToString());
        }
    }
}
