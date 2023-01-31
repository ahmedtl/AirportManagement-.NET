// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
Plane plane= new Plane();
plane.Capacity = 200;
plane.Type = PlaneType.Boing;
plane.ManufactureDate = DateTime.Now;
//Plane plane1= new Plane(PlaneType.Airbus,300,DateTime.Now);
Plane plane2 = new Plane(PlaneType.Airbus, 300, DateTime.Now);
Plane plane3 = new Plane
{
    Type = PlaneType.Airbus,
    Capacity = 170,
    ManufactureDate = new DateTime(2016, 04, 03)
};
Console.WriteLine(plane3.ToString());
Passenger passenger1 = new Passenger
{
    FirstName = "Ahmed",
    LastName = "Tlili",
    EmailAdress = "ahmed.tlili@esprit.tn"
};
Console.WriteLine(passenger1.CheckProfile("Ahmed", "tnyjyt", "ahmed.tlili@esprit.tn"));
Traveller traveller1 = new Traveller
{

    FirstName = "Rihab",
    LastName = "Nasri",
    Nationality = "Tunisian"
};
Console.WriteLine("traveller1: ");
traveller1.PassengerType();
Staff staff1 = new Staff
{
    FirstName = "Meriam",
    LastName = "Aljouna",
    Salary = 6000.0
};
Console.WriteLine("Staff1: ");
staff1.PassengerType();