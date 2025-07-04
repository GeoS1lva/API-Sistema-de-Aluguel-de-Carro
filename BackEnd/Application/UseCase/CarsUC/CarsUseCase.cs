using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Infrastructure;

namespace AluguelDeCarro.Application.UseCase.CarsUC
{
    public class CarsUseCase(IUnitOfWork unitOfWork, IValidatePlate validatePlate) : ICarsUseCase
    {
        
        public async Task<ResultModel> RegisterCar(RegisterCar registerCar)
        {

            if (validatePlate.CheckPlate(registerCar.LicensePlate).Result == false)
                return new ResultModel("Placa de Carro está fora do padrão MercoSul!");

            unitOfWork.CarsRepository.AddCar(CarsMapper.toDTORequst(registerCar));
            await unitOfWork.SaveChangesAsync();

            return new ResultModel(CarsMapper.toDTOResponse(registerCar));
        }

        public async Task<ResultModel> DeleteCar(string licensePlate)
        {
            var deleteCar = await unitOfWork.CarsRepository.GetByLicensePlate(licensePlate);

            if (deleteCar == null)
                return new ResultModel("Placa não identificada!");

            unitOfWork.CarsRepository.DeleteCar(deleteCar);
            await unitOfWork.CarsRepository.SaveChangesAsync();

            return ResultModel.resultSucess("Carro excluído com sucesso!");
        }
    }
}
