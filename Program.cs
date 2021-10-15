using System.Net;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;

namespace DotNet___Forca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra: ");
            string inputWord = Console.ReadLine();
            Word word = new Word(inputWord);
            const int numberOfTry = 6;

            Console.WriteLine(word.guessWord);

            Console.WriteLine("\n Vamos começar");
            int errorNum = 0;
            int tryed = 0;
                       
            while (errorNum < numberOfTry && !word.isCompleted())
            {
                Console.WriteLine("\n Digite uma letra: ");
                string letter = Console.ReadLine();
                int index = word.GetIndex(letter);
                word.AddLetterInList(letter);
                tryed++;
                if (index < 0) 
                    errorNum++;
                else
                    word.ReplaceLetter(letter);
                
                Console.WriteLine($"Letras já tentadas: {word.LettersListString()}");
                Console.WriteLine($"Você já fez {tryed} jogadas e errou {errorNum} vezes");
                Console.WriteLine(word.toString());
                
            }

            if(word.isCompleted()){
                Console.WriteLine("Muito bem, você ganhou!!!");
            }else {
                Console.WriteLine($"Tente novamente, a palavra correta é: {inputWord}");
            }
        }
    }
}
