using System;

namespace Store.Domain.StoreContext
{
    public interface IPerson
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        void OnRegister();
    }

    public interface IEmployee
    {
        public decimal Salary { get; set; }

    }
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
    public class Customer : IPerson, IEmployee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public void OnRegister()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }

}


