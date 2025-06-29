using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace AluguelDeCarro.Domain.Repository
{
    public class CarsRepository(SqlServerDbContext context) : ICarsRepository
    {
        private readonly SqlServerDbContext _context = context;

        public void AddCar(Cars car)
            => _context.cars.Add(car);

        public void DeleteCar(Cars car)
            => _context.cars.Remove(car);

        public async Task<List<Cars>> GetByCategory(CarCategory carCategory)
            => await _context.cars.Where(x => x.CarCategory == carCategory).ToListAsync();

        public async Task<List<Cars>> GetByCategoryAvailable(CarCategory carCategory)
            => await _context.cars.Where(x => x.CarCategory == carCategory && x.Available == true).ToListAsync();

        public async Task<Cars> GetByLicensePlate(string licensePlate)
            => await _context.cars.FirstOrDefaultAsync(x => x.LicensePlate == licensePlate);

        public async Task<bool> CheckByLicensePlate(string licensePlate)
            => await _context.cars.AnyAsync(x => x.LicensePlate == licensePlate);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();
    }
}
