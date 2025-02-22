using Bookify.Domain.Abstractions;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Apartments;

public sealed class Apartment : Entity
{
    private Apartment(Guid id, Name name, Description desc, Address addr, Money price, Money cleanFee, DateTime? lastBooked, List<Amenity> amenities) : base(id)
    {
        Id = id;
        Name = name;
        Description = desc;
        Address = addr;
        Price = price;
        CleaningFee = cleanFee;
        LastBookedOnUts = lastBooked;
        Amenities = amenities;
    }
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Address Address { get; private set; }
    public Money Price { get; private set; }
    public Money CleaningFee { get; private set; }
    public DateTime? LastBookedOnUts { get; internal set; }
    public List<Amenity> Amenities { get; private set; } = new();
}
