using UnitDemo.Library.Models;
using UnitDemo.Library.Services;

// See https://aka.ms/new-console-template for more information
var fac = new BikeFactory();
var bike = fac.GetBikeOfType((BikeType)5);

Console.WriteLine($"Your bike is a {bike.Description} bike, with {bike.Handlebars} bars and {bike.Tires} tires.");
