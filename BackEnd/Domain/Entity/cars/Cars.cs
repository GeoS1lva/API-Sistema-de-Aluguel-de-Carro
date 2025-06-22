namespace AluguelDeCarro.Domain.Entity.cars
{
    public class Cars(string make, string model, int year, CarFuel carFuel, CarGearbox carGearbox, int numberOfDoors, CarCategory carCategory, string licensePlate, double priceDay) : EntityBase
    {
        public string Make { get; private set; } = make;
        public string Model { get; private set; } = model;
        public int Year { get; private set; } = year;
        public CarFuel CarFuel { get; private set; } = carFuel;
        public CarGearbox CarGearbox { get; private set; } = carGearbox;
        public int NumberOfDoors { get; private set; } = numberOfDoors;
        public CarCategory CarCategory { get; private set; } = carCategory;
        public string LicensePlate { get; private set; } = licensePlate;
        public bool Available { get; private set; } = true;
        public double PriceDay { get; private set; } = priceDay;

        public void RentCar()
            => Available = false;

        public void ReturnCar()
            => Available = true;
    }
}
