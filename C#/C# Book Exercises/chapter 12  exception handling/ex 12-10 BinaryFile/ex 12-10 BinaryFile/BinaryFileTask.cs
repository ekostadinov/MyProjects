using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex_12_10_BinaryFile
{    
    class BinaryFileTask
    {
        static byte[] bytesArray;        
        static string fileName;
        static string filePath;
        

        static void Main()
        {
            Console.Write("Enter the text file name:");
            fileName = Console.ReadLine();

            Console.WriteLine("Enter the full path of the text file (example: C:\\some dir\\SomeTextFile.TXT");
            filePath = Console.ReadLine();

            Console.WriteLine("The content of the {0}.txt is: ", fileName);

            ReadBinaryFile();
            Console.WriteLine();

            ConvertBinaryToByteArray();
            
        }

        static void ReadBinaryFile()
        {
            using (BinaryReader br = new BinaryReader(File.Open(@filePath, FileMode.Open)))
            {              
                                
                // Position and length variables.
	            int pos = 0;
	    
	            // Use BaseStream.
	            int length = (int)br.BaseStream.Length;
	            while (pos < length)
	                {
		                // Read integer.
		                int v = br.ReadInt32();
		                Console.Write(v + " ");

		                // Advance our position variable.
	                	pos += sizeof(int);
	                }

                // optional code:
                // Console.WriteLine();
                // Console.WriteLine("End of file reached!");
                // Console.WriteLine("Press any key to exit!");
                // Console.ReadLine();    
            }
        }


        static void ConvertBinaryToByteArray()
        {
            Console.WriteLine();
            Console.WriteLine("Converted binary file to bytes array is: ");
            bytesArray = File.ReadAllBytes(@filePath);

            Console.WriteLine();
            foreach (var bytes in bytesArray)
            {
                Console.Write(bytes + " ");
            }

            // simple test : by loading and then compare manualy the two files
            Console.WriteLine();
            Console.WriteLine("*************");
            Console.WriteLine("First byte: {0}", bytesArray[0]);
            Console.WriteLine("Last byte: {0}", bytesArray[bytesArray.Length - 1]);
            Console.WriteLine("Length of the byte array is {0} symbols", bytesArray.Length);

            ByteArrayToFile();
        }

        static void ByteArrayToFile()
        {
            Console.WriteLine();
            Console.WriteLine("Enter full path for the new text file (example: C:\\some dir\\SomeTextFile.TXT");
            string newFileName = Console.ReadLine();

            try
            {
                // create and write new file from byte array to binary txt file
                File.WriteAllBytes(@newFileName, bytesArray);
                Console.WriteLine("The process is successfull!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught in process: {0}", e.ToString());
            }
        }
        

    }
}
