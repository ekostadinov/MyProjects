
namespace PetOwnersTask.Models
{
    using System;
    using System.Linq;

    public abstract class PersonBase
    {
        //fields
        private string firstName;
        private string lastName;               

        //constructor
        public PersonBase(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public PersonBase()
        {
        }

        //properties
        //MAYBE DONT NEED IT!!!!!!!!!!!!!!!
        public int PersonBaseId { get; set; }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name should contain some letters");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The last name should contain some letters");
                }
                this.lastName = value;
            }
        }
        // methods

    }
}
