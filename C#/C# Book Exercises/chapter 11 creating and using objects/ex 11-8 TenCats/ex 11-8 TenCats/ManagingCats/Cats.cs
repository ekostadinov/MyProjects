using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_8.ManagingCats
{
    public class Cat
    {
        // Field name
        private int name;
        
        
        public int Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name" 
            set
            {
                this.name = value;
            }
        }
                

        // The code runs without this Default constructor
        public Cat()
        {
            this.name = 0;            
        }
               

        public void SayMiau()
        {        
            for (int index = 1; index <= 10; index ++)
            {
                //Console.WriteLine(" {0} ", index);
                
                Console.WriteLine("{0}.Cat{1} said: Miauuuu!", index, name);
            }
                                   
        }

        

        public static void Execute()
        {
            Random rand = new Random();            

            for (int number = 1; number <= 10; number++)
            {
                int randomNum = rand.Next(100) + 1;
                                
                Cat someCat = new Cat();
                someCat.name = randomNum;
                someCat.SayMiau();               
            }
             
        }


    }
}