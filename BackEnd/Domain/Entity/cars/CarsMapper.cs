using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.ResponseModel;

namespace AluguelDeCarro.Domain.Entity.cars
{
    public class CarsMapper
    {
        public static Cars toDTO(RegisterCar registerCar)
        {
            return new Cars(registerCar.Make,
                registerCar.Model,
                registerCar.Year,
                registerCar.CarFuel,
                registerCar.CarGearbox,
                registerCar.NumberOfDoors,
                registerCar.CarCategory,
                registerCar.LicensePlate,
                registerCar.PriceDay
            );
        }

        public static ResponseRegisterCarModel toDTOResponse(RegisterCar registerCar)
        {
            return new ResponseRegisterCarModel(registerCar.Make,
                registerCar.Model,
                registerCar.Year,
                registerCar.LicensePlate
            );
        }
    }
}
