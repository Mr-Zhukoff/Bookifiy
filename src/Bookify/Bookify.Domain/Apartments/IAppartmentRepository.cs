namespace Bookify.Domain.Apartments;

public interface IAppartmentRepository
{
    Task<Apartment?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
