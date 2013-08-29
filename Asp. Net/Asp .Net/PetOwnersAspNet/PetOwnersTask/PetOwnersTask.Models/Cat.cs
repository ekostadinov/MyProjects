
namespace PetOwnersTask.Models
{
    using System;
    using System.Linq;

    public class Cat : PetBase
    {
        //fields 

        //constructor
        public Cat()
        {
        }

        //properties
        public int CatId { get; set; }


        //methods
		public override string ToString()
        {
            return string.Format(this.PetName + ", " + this.PetSpecies + ", " + this.PetAge);
        }
    }
}
