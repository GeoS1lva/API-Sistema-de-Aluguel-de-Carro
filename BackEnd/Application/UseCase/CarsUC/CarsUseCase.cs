using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Application.UseCase.CarsUC
{
    public class CarsUseCase(ICarsRepository carsRepository, IValidatePlate validatePlate) : ICarsUseCase
    {
        
        public ResultModel RegisterCar(RegisterCar registerCar)
        {

            if (validatePlate.ValidatePlate(registerCar.LicensePlate).Result == false)
                return new ResultModel("Placa de Carro fora do padrão MercoSul!");

            carsRepository.AddCar(CarsMapper.toDTO(registerCar));
            carsRepository.SaveChangesAsync();

            return new ResultModel(CarsMapper.toDTOResponse(registerCar));
        }
    }
}
