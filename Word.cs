using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DotNet___Forca
{
    public class Word
    {
        private string myWord;
        public string guessWord;

        public List<string> lettersTry {get; private set;}
        public Word(string w)
        {
            lettersTry = new List<string>();
            myWord = w;
            guessWord = new string('_', myWord.Length);
        }

        public int GetIndex(string letra)
        {
            return myWord.IndexOf(letra);
        }

        public bool isCompleted(){
            return !guessWord.Contains("_");
        }
        public void AddLetterInList(string l)
        {
            if(!lettersTry.Contains(l))
                lettersTry.Add(l);
        }

        public string LettersListString(){
            var lista = "";
            lettersTry.ForEach(l => lista +=$" {l}");
            return lista;
        }

        public void ReplaceLetter(string letter)
        {
            for (int i = 0; i < myWord.Length; i++)
            {
                if(myWord[i] == letter[0]){
                    
                    var letters = guessWord.ToCharArray();
                    letters[i] = letter[0];
                    guessWord = String.Concat(letters);
                }
            }

            
        } 
        public string toString(){
            return this.guessWord;
        }
        
    }
}
