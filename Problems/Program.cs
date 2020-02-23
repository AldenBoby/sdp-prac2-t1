using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            int num_letters = input.Length;
            int loop = 0;
            int word_counter = 0;
            bool space = true;//initialised at true so first word is counted

            while (loop<num_letters)
            { 
                while (input[loop]==' ')
                {
                    space = true;
                    loop++;//iterate through space chars
                    if (loop==num_letters)
                    {
                        space = false;//prevent counter from increasing when result is found
                        break;//prevent out of bounds
                    }
                }
                if (space == true)
                {
                    word_counter++;//starting new word 
                    space = false;
                }
                loop++;
            }
            return num_letters+","+word_counter+":"+input;//return output string
        }
        static void Main(string[] args)
        {
            Program Prfx = new Program();
            Prfx.Prefix("Hello");
            Prfx.Prefix("");
            Prfx.Prefix("what    ...  did you say?? ");
        }
    }
}
