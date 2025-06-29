namespace AluguelDeCarro.Domain.Entity.cars
{
    public interface ICarsRepository
    {
        public void AddCar(Cars car);
        public void DeleteCar(Cars car);
        public Task<List<Cars>> GetByCategory(CarCategory carCategory);
        public Task<List<Cars>> GetByCategoryAvailable(CarCategory carCategory);
        public Task<Cars> GetByLicensePlate(string licensePlate);
        public Task<bool> CheckByLicensePlate(string licensePlate);
        public Task SaveChangesAsync();
    }
}
