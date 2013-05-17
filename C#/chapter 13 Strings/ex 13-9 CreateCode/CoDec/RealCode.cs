using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDec
{
    class RealCode
    {
        static void Main()
        {
            string cypher = "Tova e kodirashtiq string";
            string line = Console.ReadLine();
            line = CoDec(line, cypher);
            Console.WriteLine("Encrypted:\n{0}", line);
            line = CoDec(line, cypher);
            Console.WriteLine("Decrypted:\n{0}", line);
        }

        static string CoDec(string line, string cypher)
        {
            Queue<char> cypherQ = new Queue<char>(cypher);
            StringBuilder output = new StringBuilder();
            char code;
            foreach (char item in line)
            {
                code = cypherQ.Dequeue();
                cypherQ.Enqueue(code);
                output.Append((char)(item ^ code));
            }
            return output.ToString();
        }
    }
}
