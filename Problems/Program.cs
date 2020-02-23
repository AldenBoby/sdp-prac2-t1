using System;

namespace Problems
{
    public class Program
    {
        static void Prefix(string input)
        {
            int num_letters = input.Length;

            int loop = 0;
            int word_counter = 0;
            bool space = true;

            while (loop<num_letters)
            { 
                while (input[loop]==' ')
                {
                    space = true;
                    loop++;
                    if (loop==num_letters)
                    {
                        space = false;
                        break;
                    }
                }
                if (space == true)
                {
                    word_counter++;
                    space = false;
                }
                loop++;
            }
            Console.WriteLine(num_letters+","+word_counter+":"+input);
        }
        static void Main(string[] args)
        {
            Prefix("Hello");
            Prefix("");
            Prefix("what    ...  did you say?? ");
        }
    }
}
