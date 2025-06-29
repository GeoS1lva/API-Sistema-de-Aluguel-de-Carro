using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Application.RequestModel
{
    public class RegisterCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public CarFuel CarFuel { get; set; }
        public CarGearbox CarGearbox { get; set; }
        public int NumberOfDoors { get; set; }
        public CarCategory CarCategory { get; set; }
        public string LicensePlate { get; set; }
        public double PriceDay { get; set; }

    }
}
