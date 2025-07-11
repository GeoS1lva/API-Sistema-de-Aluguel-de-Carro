﻿namespace AluguelDeCarro.Domain.Entity.employeeLogin
{
    public class EmployeeLogin(string user, byte[] password, byte[] salt) : EntityBase
    {
        public string User { get; private set; } = user;
        public byte[] Password { get; private set; } = password;
        public byte[] Salt { get; private set; } = salt;
    }
}
