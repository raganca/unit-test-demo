using UnitDemo.Library.Models;

namespace UnitDemo.Library.Services
{
    public interface IBikeFactory
    {
        IBike GetBikeOfType(BikeType bikeType);
    }

    public class BikeFactory : IBikeFactory
    {
        public IBike GetBikeOfType(BikeType bikeType)
        {
            return new Bike
            {
                Description = bikeType.ToString(),
                Handlebars = bikeType switch
                {
                    BikeType.Road or
                    BikeType.Gravel => BarType.Drop,
                    BikeType.Mountain or
                    BikeType.Hybrid or
                    BikeType.Fat => BarType.Flat,
                    _ => BarType.Flat
                },
                Tires = bikeType switch
                {
                    BikeType.Road => TireType.Slick,
                    BikeType.Gravel => TireType.Hybrid,
                    BikeType.Mountain => TireType.Knobby,
                    BikeType.Hybrid => TireType.Hybrid,
                    BikeType.Fat => TireType.Fat,
                    _ => TireType.Hybrid
                }
            };
        }
    }
}
