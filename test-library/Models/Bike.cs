namespace UnitDemo.Library.Models
{
    public interface IBike
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BarType Handlebars { get; set; }
        public TireType Tires { get; set; }
    }

    public class Bike : IBike
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public BarType Handlebars { get; set; }
        public TireType Tires { get; set; }
    }

    public enum BarType
    {
        Flat,
        Drop
    }

    public enum TireType
    {
        Slick,
        Hybrid,
        Knobby,
        Fat
    }

    public enum BikeType
    {
        Road,
        Mountain,
        Gravel,
        Hybrid,
        Fat
    }
}