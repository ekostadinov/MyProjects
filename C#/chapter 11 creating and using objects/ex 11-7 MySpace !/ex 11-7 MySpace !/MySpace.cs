using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ex_11_7_MySpace.Chapter11;



namespace ex_11_7_MySpace
{
    class MySpace
    {
        static void Main()
        {
            // logic to print results: 
            // 1. type "using" and the required namespace ("ex_11_7_MySpace.Chapter11")
            // 2. type the namespace.folder.class.method

            Console.WriteLine("The Cat example: ");
            ex_11_7_MySpace.Chapter11.Cat.Execute();
            Console.WriteLine();

            Console.WriteLine("The sequence example:");
            ex_11_7_MySpace.Chapter11.Sequence.SequenceManipulating();
            Console.WriteLine();
            
        }        
    }
}
