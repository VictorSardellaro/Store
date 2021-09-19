using System;
using FluentValidator;
using Store.Domain.StoreContext.Enums;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.CustomerCommands.Inputs
{
    public class AddAddressCommand : Notifiable, ICommand
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

        bool ICommand.Valid()
        {
            return IsValid;
        }

    }
}