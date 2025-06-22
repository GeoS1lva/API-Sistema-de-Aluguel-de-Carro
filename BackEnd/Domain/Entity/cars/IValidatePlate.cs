namespace AluguelDeCarro.Domain.Entity.cars
{
    public interface IValidatePlate
    {
        public Task<bool> ValidatePlate(string licensePlate);
    }
}
