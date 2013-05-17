using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex_11_11_RandomMessage;

namespace ex_11_11_RandomMessage
{
    class CreateMessage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Try out our product! Here it is a happy customer reply: ");
            
            ex_11_11_RandomMessage.FirstMessage.GenerateNumbers(); 
            ex_11_11_RandomMessage.SecondMessage.GenerateNumbers2();
            ex_11_11_RandomMessage.FirstName.GenerateName();
            ex_11_11_RandomMessage.SecondName.GenerateName2();
            ex_11_11_RandomMessage.GenerateCity.GenerateCitys();
            
        }
    }
}
