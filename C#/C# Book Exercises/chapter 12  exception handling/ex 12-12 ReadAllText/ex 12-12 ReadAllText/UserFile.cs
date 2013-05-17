using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex_12_12_ReadAllText
{
    class UserFile
    {
        static void Main()
        {
            Console.WriteLine("Enter full file path: ");
            string filePath = Console.ReadLine();
            try
            {
                string file = File.ReadAllText(@filePath);
                Console.WriteLine("The content in the {0} is:", filePath);
                Console.WriteLine();
                Console.WriteLine(file);

                Console.WriteLine();
                Console.WriteLine("End of file reached!");
                Console.WriteLine("Press any key to exit!");
                Console.ReadLine(); 
            }
            catch (FileNotFoundException fnfe)
            {
                //Console.WriteLine("Message  = {0}", fnfe.Message);
                //Console.WriteLine("Source  = {0}", fnfe.Source);
                //Console.WriteLine("Stack trace  = {0}", fnfe.StackTrace);
                //Console.WriteLine("Target site  ={0}", fnfe.TargetSite);
                Console.WriteLine("File Not Found!Please try again!");
            }
            catch (FieldAccessException fae)
            {
                //Console.WriteLine("Message  = {0}", fae.Message);
                //Console.WriteLine("Source  = {0}", fae.Source);
                //Console.WriteLine("Stack trace  = {0}", fae.StackTrace);
                //Console.WriteLine("Target site  ={0}", fae.TargetSite);
                Console.WriteLine("There is no Field Access to this file!");
            }
            catch (FileLoadException fle)
            {
                //Console.WriteLine("Message  = {0}", fle.Message);
                //Console.WriteLine("Source  = {0}", fle.Source);
                //Console.WriteLine("Stack trace  = {0}", fle.StackTrace);
                //Console.WriteLine("Target site  ={0}", fle.TargetSite);
                Console.WriteLine("There is a problem with the File Loading!");
            }
            catch (Exception e)
            {
                //Console.WriteLine("Message  = {0}", e.Message);
                //Console.WriteLine("Source  = {0}", e.Source);
                //Console.WriteLine("Stack trace  = {0}", e.StackTrace);
                //Console.WriteLine("Target site  ={0}", e.TargetSite);
                Console.WriteLine("An error has been found while reading the file!");
                Console.WriteLine("Please contact your IT administrator.");
            }
            finally
            {                
                // file must be Closed
            }

            
        }
    }
}
