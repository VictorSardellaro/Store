using System;
using Store.Domain.StoreContext.Enums;

namespace Store.Domain.StoreContext.CustomerCommands.Inputs
{
    public class AddAddressCommand
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Disctrict { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }

    }
}