using System;
using FluentValidator;
using Store.Domain.StoreContext.CustomerCommands.Inputs;
using Store.Domain.StoreContext.CustomerCommands.Outputs;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.Repositories;
using Store.Domain.StoreContext.Services;
using Store.Domain.StoreContext.ValueObjects;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.Handlers
{
    public class CustomerHandler :
        Notifiable,
        ICommandHandler<CreateCustomerCommand>,
        ICommandHandler<AddAddressCommand>
    {
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;
        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;

        }
        public ICommandResult Handle(CreateCustomerCommand command)
        {
            // Verificar se o CPF já existe na base
            if (_repository.CheckDocument(command.Document))
            {
                AddNotification("Document", "Este CPF já está em uso");
            }

            // Verificar se o E-mail já existe na base
            if (_repository.CheckEmail(command.Email))
            {
                AddNotification("Email", "Este E-mail já está em uso");
            }

            // Criar os VOs
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);

            // Criar a entidade
            var customer = new Customer(name, document, email, command.Phone);

            // validar endidades e VOs
            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            if (Invalid)
                return null;

            // Persistir o cliente
            _repository.Save(customer);

            // Enviar um E-mail de boas vindas
            _emailService.Send(email.Address, "victor.gonzalez@hotmail.com", "Bem vindo", "Seja bem vindo a Loja");

            // Retornar o resultado para a tela
            return new CreateCustomerCommandResult(customer.Id, name.ToString(), email.Address);
        }

        public ICommandResult Handle(AddAddressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}