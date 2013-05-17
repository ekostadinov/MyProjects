using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex_13_10_SearchText
{
    class FindSentence
    {
        static void Main()
        {
            //finds words consists keyword
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
                       
            string keyWord = "in";
            
            string[] sentences = text.Split('.');

            int position = 0;

            foreach (var sentence in sentences)
            {
                //if (text.IndexOf(keyWord) != -1) //need checking logic if keyword is a part of another word
                //{
                //    Console.WriteLine(sentence);
                //}

                position = sentence.IndexOf(keyWord, StringComparison.CurrentCultureIgnoreCase);
                while (position >= 0)
                {
                    if (position >= 0 && !char.IsLetter(sentence[position - 1]) && !char.IsLetter(sentence[position + keyWord.Length]))
                    {
                        Console.WriteLine(sentence.Trim()+ ".");
                    }
                    position = sentence.IndexOf(keyWord, position + 1, StringComparison.CurrentCultureIgnoreCase);
                }                
            }
        }
    }
}
