using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Infrastructure.VehicleCar
{
    public class ValidatePlate(ICarsRepository carsRepository) : IValidatePlate
    {
        public async Task<bool> ValidatePlate(string licensePlate)
        {
            if (licensePlate.Length != 6)
                return false;

            if(!await carsRepository.GetByLicensePlate(licensePlate))
                return false;

            char[] plate = licensePlate.ToCharArray();

            if (!Char.IsLetter(plate[0]) || !Char.IsLetter(plate[1]) || !Char.IsLetter(plate[2]) || !Char.IsLetter(plate[4]))
                return false;

            if (!Char.IsDigit(plate[3]) || !Char.IsDigit(plate[5]) || !Char.IsLetter(plate[6]))
                return false;

            return true;
        }
    }
}
