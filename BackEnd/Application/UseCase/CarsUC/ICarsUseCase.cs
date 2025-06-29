using AluguelDeCarro.Application.RequestModel;

namespace AluguelDeCarro.Application.UseCase.CarsUC
{
    public interface ICarsUseCase
    {
        public Task<ResultModel> RegisterCar(RegisterCar registerCar);
        public Task<ResultModel> DeleteCar(string licensePlate);
    }
}
