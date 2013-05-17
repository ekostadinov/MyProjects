using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_11_7_MySpace.Chapter11
{
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0;

        //Intentionally deny instantiation of this class

        private Sequence()
        {
        }

        // Static method for taking the next sequnce value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
           
        public static void SequenceManipulating ()
        {
            Console.WriteLine("Sequence 1..3: {0}, {1}, {2}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
        }

    }        
}
