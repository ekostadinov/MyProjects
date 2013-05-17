using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyParseException
{
    class CustomParseException : Exception
    {       
        public long LineNumber { get; private set; }
    }

    class TestMyException
    {
        static long lineNum;
        
        static void Main()
        {  
            string filePath = "D:\\nums.txt";

            //pass the file path via string
            StreamReader sr = new StreamReader(@filePath);
            

           
            //Read the first line of text
            try
            {
                string line = sr.ReadLine();
                lineNum = 0;
                long number;
                bool parsed = long.TryParse(line, out number);

                //Continue to read until you reach end of file
                while (line != null && parsed == false)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    lineNum++;
                    if (parsed == false)
                    {
                        throw new CustomParseException();
                    }
                }
            }            
            catch (CustomParseException cpe)
            {
                //not working correctly about on whisch line an error has been found!
                Console.WriteLine("Message {0}", cpe.Message);
                Console.WriteLine("Stack trace {0}", cpe.StackTrace);
                Console.WriteLine("Source {0}", cpe.Source);
                Console.WriteLine("TargetSite {0}", cpe.TargetSite);
                Console.WriteLine("Error found on line: {0}", lineNum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message {0}", e.Message);
            }
            finally
            {
                //close the file
                sr.Close();
            }

            Console.WriteLine();
            Console.WriteLine("End of file reached!");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine(); 
        }
    }
}
