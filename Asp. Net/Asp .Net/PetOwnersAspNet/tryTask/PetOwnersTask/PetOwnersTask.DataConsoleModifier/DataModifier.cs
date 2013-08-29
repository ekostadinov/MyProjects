using PetOwnersTask.Data;
using PetOwnersTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetOwnersTask.DataConsoleModifier
{
    internal class DataModifier
    {
        static void Main()
        {
            var db = new PetOwnersContext();
            var ownerSmith = new Owner() { FirstName = "John", LastName = "Smith", Age = 27 };
            var petRex = new Dog() { PetName = "Rex", PetSpecies = "Dog", PetAge = 3, Owner = ownerSmith };
            var petGoldy = new Dog() { PetName = "Goldy", PetSpecies = "Fish", PetAge = 2, Owner = ownerSmith };
            ownerSmith.Pets.Add(petRex);
            ownerSmith.Pets.Add(petGoldy);

            //Console.WriteLine("{0}'s pets are: ", ownerSmith.FirstName);
            //foreach (var item in ownerSmith.Pets)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            db.Owners.Add(ownerSmith);

                      
            //PetBase petRex = new Dog();
            ////(Dog)petRex.DogId = 1;
            //petRex.Owner = ownerSmith;
            //petRex.PetName = "Rex";
            //petRex.PetSpecies = "Dog";
            //petRex.PetAge = 3;
            //db.Pets.Add(petRex);

            db.SaveChanges();

            //Console.WriteLine(petRex.ToString());
        }
    }
}
