using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Infrastructure.VehicleCar
{
    public class ValidatePlate(ICarsRepository carsRepository) : IValidatePlate
    {
        public async Task<bool> CheckPlate(string licensePlate)
        {
            if (licensePlate.Length != 7)
                return false;

            if(await carsRepository.CheckByLicensePlate(licensePlate))
                return false;

            char[] plate = licensePlate.ToCharArray();

            if (!Char.IsLetter(plate[0]) || !Char.IsLetter(plate[1]) || !Char.IsLetter(plate[2]) || !Char.IsLetter(plate[4]))
                return false;

            if (!Char.IsNumber(plate[3]) || !Char.IsNumber(plate[5]) || !Char.IsNumber(plate[6]))
                    return false;

            return true;
        }
    }
}
