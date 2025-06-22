namespace AluguelDeCarro.Domain.Entity.cars
{
    public interface ICarsRepository
    {
        public void AddCar(Cars car);
        public void DeleteCar(string licensePlate);
        public Task<List<Cars>> GetByCategory(CarCategory carCategory);
        public Task<List<Cars>> GetByCategoryAvailable(CarCategory carCategory);
        public Task<bool> GetByLicensePlate(string licensePlate);
        public Task SaveChangesAsync();
    }
}
