using System;
using System.Collections.Generic;
using System.Linq;


namespace Reverse.Api.Services
{
    public interface IStringReverseService
    {
        string Reverse(string inputString);
    }

    public class StringReverseService : IStringReverseService
    {
        public string Reverse(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return string.Empty;

            var splitedStringArray = inputString.Split(new char[] { ' ' });
            int c = splitedStringArray.Length;
            var resultList = new string[c];
            
            for(int x = 0, y = c; x < c; x++, y--)
            {
                resultList[x] = ReverseWord(splitedStringArray[y - 1]);
            }

            
            return string.Join(" ", resultList); 
        }

        
        private string ReverseWord(string word)
        {
            if (word.Length <= 1)
                return word;
            else
                return ReverseWord(word.Substring(1)) + word[0];
        }
        
    }
}