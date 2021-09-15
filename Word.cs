using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DotNet___Forca
{
    public class Word
    {
        private string myWord;
        public string guessWord;

        public Word(string w)
        {
            myWord = w;
            guessWord = new string('_', myWord.Length);
        }

        public int GetIndex(char letra)
        {
            return myWord.IndexOf(letra);
        }

        public void ReplaceLetter(char letter)
        {
            for (int i = 0; i < length; i++)
            {
                if(myWord[i] == letter)
                    guessWord[i] = letter;
            } 
            
        }  
        
    }
}
