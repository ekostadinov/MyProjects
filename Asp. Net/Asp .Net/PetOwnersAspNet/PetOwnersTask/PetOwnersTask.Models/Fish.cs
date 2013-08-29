
namespace PetOwnersTask.Models
{
    using System;
    using System.Linq;

    class Fish : PetBase
    {
        //fields 

        //constructor
        public Fish()
        {

        }


        //properties
        public int FishId { get; set; }


        //method
		public override string ToString()
        {
            return string.Format(this.PetName + ", " + this.PetSpecies + ", " + this.PetAge);
        }
    }
}
