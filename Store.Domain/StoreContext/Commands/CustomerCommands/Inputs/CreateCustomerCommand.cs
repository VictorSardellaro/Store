using FluentValidator;
using FluentValidator.Validation;

namespace Store.Domain.StoreContext.CustomerCommands.Inputs
{
    public class CreateCustomerCommand : Notifiable
    {
        // FailFastValidation

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool Valid()
        {
            AddNotifications(
                new ValidationContract()
                    .Requires()
                    .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(FirstName, 40, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                    .HasMinLen(LastName, 3, "FirstName", "O sobrenome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(LastName, 40, "FirstName", "O sobrenome deve conter pelo menos 3 caracteres")
                    .IsEmail(Email, "Email", "O E-mail é inválido")
                    .HasLen(Document, 11, "Document", "CPF inválido")
            );
            return Valid();
        }

        // Se o usuario existe no banco (Email)
        // Se o usuario existe no banco (CPF)




    }
}