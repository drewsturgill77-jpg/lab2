System.Console.WriteLine("How many miles for your trip?");
double tripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How many miles per gallon can your car go?");
double milePerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How much did you pay for gas?");
double pricePerGallon = Convert.ToDouble(System.Console.ReadLine());

//Calulations for Part 1
double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print the calculations
System.Console.WriteLine("gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("fuel cost: " + fuelCost.ToString("C"));
