using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Application.RequestModel
{
    public class RegisterCar
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public CarFuel CarFuel { get; private set; }
        public CarGearbox CarGearbox { get; private set; }
        public int NumberOfDoors { get; private set; }
        public CarCategory CarCategory { get; private set; }
        public string LicensePlate { get; private set; }
        public double PriceDay { get; private set; }

    }
}
