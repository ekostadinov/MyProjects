
namespace PetOwnersTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //owner == category
    //pets == post
    public class Owner : PersonBase
    {
        //fields
        private int age;
        private ICollection<PetBase> pets;

        //constructor
        public Owner()
        {
            this.pets = new List<PetBase>();
        }

        //properties
        public int OwnerId { get; set; }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <=1 || value > 100)
                {                                       
                    throw new ArgumentOutOfRangeException("Owner must be at in range 1-100 years old.");
                }
				this.age = value; 
            }
        }

        public virtual PetBase Pet { get; set; }

        public int PetId { get; set; }


        public virtual ICollection<PetBase> Pets
        {
            get { return pets; }
            set { pets = value; }
        }
        
        //methods

    }
}
