using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex_12_9_ReadAFile
{
    class ReadAFile
    {
        static void Main()
        {
            Console.Write("Enter the text file name:");
            string fileName = Console.ReadLine();

            Console.WriteLine("Enter the full path of the text file (example: C:\\some dir\\SomeTextFile.TXT");
            
            string filePath = Console.ReadLine();
           
            //pass the file path via string
            StreamReader sr = new StreamReader(@filePath);

            Console.WriteLine("The content of the {0}.txt is: ", fileName);
            //Read the first line of text

            try
            {
                string line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Message  = {0}", fnfe.Message);
                Console.WriteLine("Source  = {0}", fnfe.Source);
                Console.WriteLine("Stack trace  = {0}", fnfe.StackTrace);
                Console.WriteLine("Target site  ={0}", fnfe.TargetSite);
            }
            catch (FieldAccessException fae)
            {
                Console.WriteLine("Message  = {0}", fae.Message);
                Console.WriteLine("Source  = {0}", fae.Source);
                Console.WriteLine("Stack trace  = {0}", fae.StackTrace);
                Console.WriteLine("Target site  ={0}", fae.TargetSite);
            }
            catch (FileLoadException fle)
            {
                Console.WriteLine("Message  = {0}", fle.Message);
                Console.WriteLine("Source  = {0}", fle.Source);
                Console.WriteLine("Stack trace  = {0}", fle.StackTrace);
                Console.WriteLine("Target site  ={0}", fle.TargetSite);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message  = {0}", e.Message);
                Console.WriteLine("Source  = {0}", e.Source);
                Console.WriteLine("Stack trace  = {0}", e.StackTrace);
                Console.WriteLine("Target site  ={0}", e.TargetSite);
            }
            finally
            {
                //close the file
                sr.Close();
            }

            Console.WriteLine("End of file reached!");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();            
        }



    }
}
