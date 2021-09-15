using System.Net;
using System.ComponentModel;
using System.Data;
using System;

namespace DotNet___Forca
{
    public class Program
    {
        /*
        bool TemLetra(char letra)
        {

        }
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra: ");
            string inputWord = Console.ReadLine();
            Word word = new Word(inputWord);
            const int numberOfTry = 6;

            Console.WriteLine(word.guessWord);

            Console.WriteLine("\n Vamos começar");
            int errorNum = 0;
            
            while (errorNum < numberOfTry)
            {
                Console.WriteLine("\n Digite uma letra: ");
                char letter = Console.ReadLine();
                int index = word.GetIndex(letter);
                
                if (index < 0) 
                    errorNum++;
                else
                    word.ReplaceLetter(letter);
                
                Console.WriteLine(word);
                
            }

           
            
                
                
               
            
        }
    }
}
