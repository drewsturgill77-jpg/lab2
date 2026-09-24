/*
* Name: Drew Sturgill
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 24, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
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

System.Console.WriteLine("How many people are going");
double numPeople = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("How many pizzas?");
double numPizzas = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Price per pizza?");
double pricePerPizza = Convert.ToDouble(System.Console.ReadLine());

const double slicesPerPizza = 8;

//Calculations for Part 2
double totalSlices = numPizzas * slicesPerPizza;
double pizzaSlicesPerPerson = totalSlices / numPeople;
double pizzaCost = numPizzas * pricePerPizza;
//Print the calculations
System.Console.WriteLine("Total slices: " + totalSlices);
System.Console.WriteLine("Pizza slices per person: " + pizzaSlicesPerPerson.ToString("F2"));
System.Console.WriteLine("Total pizza cost: " + pizzaCost.ToString("C"));

System.Console.WriteLine("Hours worked this week?");
double hoursWorked = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Hourly rate?");
double hourlyRate = Convert.ToDouble(System.Console.ReadLine());

const double taxRate = 0.18;

//Calculations for Part 3
double grossPay = hoursWorked * hourlyRate;
double taxWitheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWitheld;
//Print the calculations
System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax witheld: " + taxWitheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

//Calculations for Part 4
double totalCost = fuelCost + pizzaCost;
double costPerPerson = totalCost / numPeople;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;
//Print the calculations
System.Console.WriteLine("Total cost: " + totalCost.ToString("C"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work: " + hoursYouMustWork.ToString("F2"));
