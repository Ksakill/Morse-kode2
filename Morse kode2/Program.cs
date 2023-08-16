using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_kode2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<char, String> morse = new Dictionary<char, String>() // creation of a dictionary 
            { // the letters and numbers mores code and not are down below conteined in the dictionary above
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'Æ' , ".-.-" },
                {'Ø' , "---." },
                {'Å' , ".--.-" },
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };



            Console.WriteLine("Press any key..."); // press any button to go on with the next part of the code
            Console.ReadKey(); // a readkey that allows the press any key to go into motion letting the program go on

            Console.WriteLine("Write something:"); // write somthing 
            String input = Console.ReadLine(); // the input string is console.readline
            input = input.ToUpper(); // the input is input.ToUpper

            for (int i = 0; i < input.Length; i++) // i is 0 so long as i is smaller then the inputlength add more to it
            {
                if (i > 0) // if i is bigger then 0 do what is below
                    Console.Write('/'); // wirite /

                char c = input[i]; // a chat that says the input[i] is c
                if (morse.ContainsKey(c)) // if the Morse contanskey(c)) occurs do what is below
                    Console.Write(morse[c]); // write Morse[c])
            }

            Console.WriteLine(); // just a console write line that writes what has been converted
        }
    }
}
// used a whole lot of online help for this one as i wasnt fully sure how to get this done, It wanst hard to understand when i got it tho.