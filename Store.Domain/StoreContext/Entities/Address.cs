using Store.Domain.StoreContext.Enums;

namespace Store.Domain.StoreContext.Entities
{
    public class Address
    {
        public Address(
         string street,
         string number,
         string complement,
         string disctrict,
         string city,
         string state,
         string country,
         string zipCode,
         EAddressType type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Disctrict = disctrict;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;

        }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Disctrict { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{State}";
        }
    }
}