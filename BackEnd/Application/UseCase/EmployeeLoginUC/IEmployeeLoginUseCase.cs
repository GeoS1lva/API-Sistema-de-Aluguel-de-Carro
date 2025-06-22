using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Domain.Entity;

namespace AluguelDeCarro.Application.UseCase.EmployeeLoginUC
{
    public interface IEmployeeLoginUseCase
    {
        public Task<ResultModel> CreateUser(RequestEmployeeLogin request);
        public Task<ResultModel> RequestEmployeeLogin(RequestEmployeeLogin request);
    }
}
