using FluentValidator;
using FluentValidator.Validation;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(
                new ValidationContract()
                    .Requires()
                    .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(FirstName, 40, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                    .HasMinLen(LastName, 3, "FirstName", "O sobrenome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(LastName, 40, "FirstName", "O sobrenome deve conter pelo menos 3 caracteres")
            );
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}