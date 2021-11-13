using System;

//206454
//SAFIU WAHEED
//COMPUTER SCIENCE

namespace ReverseWord
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string text = "I know and I know if I can trust Him, " +
                "He can save me from the impending doom if only I " +
                "believe in Him";

            //splitting string
            string[] text_arr = text.Split();

            int length = text_arr.Length;

            //reversing the the text array
            string[] reverse_text_arr = new string[length];
            for (int i = 0; i < length ; i++ )
                reverse_text_arr[i] = text_arr[length - (i + 1)];
            
            //Joning the reverse text array to form the reverse string
            string sentence = string.Join(" ", reverse_text_arr);

            Console.WriteLine("The reverse of ({0}) is: ", text);
            Console.WriteLine(sentence);
        }
    }
}
