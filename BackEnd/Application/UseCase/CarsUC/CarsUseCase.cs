using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Domain.Entity.cars;

namespace AluguelDeCarro.Application.UseCase.CarsUC
{
    public class CarsUseCase(ICarsRepository carsRepository, IValidatePlate validatePlate) : ICarsUseCase
    {
        
        public async Task<ResultModel> RegisterCar(RegisterCar registerCar)
        {

            if (validatePlate.CheckPlate(registerCar.LicensePlate).Result == false)
                return new ResultModel("Placa de Carro está fora do padrão MercoSul!");

            carsRepository.AddCar(CarsMapper.toDTORequst(registerCar));
            await carsRepository.SaveChangesAsync();

            return new ResultModel(CarsMapper.toDTOResponse(registerCar));
        }

        public async Task<ResultModel> DeleteCar(string licensePlate)
        {
            var deleteCar = await carsRepository.GetByLicensePlate(licensePlate);

            if (deleteCar == null)
                return new ResultModel("Placa não identificada!");

            carsRepository.DeleteCar(deleteCar);
            await carsRepository.SaveChangesAsync();

            return ResultModel.resultSucess("Carro excluído com sucesso!");
        }
    }
}
