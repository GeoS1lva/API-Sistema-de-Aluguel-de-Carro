﻿using System.ComponentModel;
using System.Diagnostics;
using AluguelDeCarro.Application.RequestModel;
using AluguelDeCarro.Application.ResponseModel;
using AluguelDeCarro.Domain.Entity;
using AluguelDeCarro.Domain.Service;
using AluguelDeCarro.Infrastructure.Login;

namespace AluguelDeCarro.Application.UseCase
{
    public class EmployeeLoginUseCase(IEmployeeLoginRepository employeeLoginRepository, IPasswordHasher hasher) : IEmployeeLoginUseCase
    {

        public async Task<ResultModel> CreateUser(RequestEmployeeLogin request)
        {
            if (!request.UserName.Contains("."))
                return new ResultModel("O Usuario precisa seguir o padrão nome.sobrenome!");

            if (request.Passwords.Length < 10)
                return new ResultModel("A senha deve conter no mínimo 10 caracteres");

            byte[] salt = hasher.GenerateSaltUser();

            byte[] hashPassword = hasher.GeneratePasswordInternal(salt, request.Passwords);

            EmployeeLogin employee = new EmployeeLogin(request.UserName, hashPassword, salt);

            employeeLoginRepository.AddUser(employee);
            await employeeLoginRepository.SaveChangesAsync();

            ResponseCreateUser responseCreateUser = new ResponseCreateUser(employee.User);

            return new ResultModel(responseCreateUser.ToString());
        }

        public async Task<ResultModel> RequestEmployeeLogin(RequestEmployeeLogin request)
        {
            EmployeeLogin employee = await employeeLoginRepository.ReceiveUser(request.UserName);

            if (employee == null)
                return new ResultModel("Usuário não encontrado");

            bool Result = hasher.ValidatePasswordInternal(employee, employee.Salt, request.Passwords);

            if (!Result)
                return new ResultModel("Senha Incorreta");                                           

            return new ResultModel(Result);
        }
    }
}
