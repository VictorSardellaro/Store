using System;

namespace Store.Domain.StoreContext
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
    public class Customer : Person
    {
        // Propriedades


        // Metodos
        public void Register() { }


        // Eventos
        public void AoRegistar() { }
    }

    public class SalesMan : Person
    {

    }

    public class Teste
    {
        public Teste()
        {

        }

    }
}


