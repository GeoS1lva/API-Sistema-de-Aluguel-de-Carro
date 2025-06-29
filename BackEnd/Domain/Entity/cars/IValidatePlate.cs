namespace AluguelDeCarro.Domain.Entity.cars
{
    public interface IValidatePlate
    {
        public Task<bool> CheckPlate(string licensePlate);
    }
}
