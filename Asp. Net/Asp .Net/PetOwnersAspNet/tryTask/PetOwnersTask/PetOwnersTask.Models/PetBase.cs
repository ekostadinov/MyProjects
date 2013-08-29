
namespace PetOwnersTask.Models
{
    using System;
    using System.Linq;

    //I still consider that the inheritance of the pets should be via IAnimal interface, but honestly when I created it 
    //that way I got Invalid Operation Exception which I couldn't find and fix, so... base class it is  
    public abstract class PetBase
    {
        //fields        
        private string petName;
        private string petSpecies;
        private Gender petGender;
        private int petAge;

        //constructor
        public PetBase()
        {
        }

        //properties        
        public Gender PetGender
        {
            get
            {
                return this.petGender;
            }
            set
            {
                this.petGender = value;
            }
        }

        public string PetName
        {
            get
            {
                return this.petName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The pet's name should contain some letters");
                }
                this.petName = value;
            }
        }

        public string PetSpecies
        {
            get
            {
                return this.petSpecies;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The pet's species should contain some letters");
                }
                this.petSpecies = value;
            }
        }

        public int PetAge
        {
            get
            {
                return this.petAge;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Pet's age must be at least 0 years old.");
                }

                this.petAge = value;
            }
        }

        public int PetBaseId { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
                
    }
}
