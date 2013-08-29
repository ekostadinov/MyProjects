
namespace PetOwnersTask.Models
{
    using System;
    using System.Linq;

    public class Dog : PetBase
    {
        //fields 

        //constructor
        public Dog()
        {
        }

        //properties
        public int DogId { get; set; }


        //methods       
		public override string ToString()
        {
            return string.Format(this.PetName + ", " + this.PetSpecies + ", " + this.PetAge);
        }

    }
}
