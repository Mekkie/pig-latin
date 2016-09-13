using System;


namespace _04_Pig_Latin
{
    internal class Translator
    {
        internal string Translate(string v)
        {
            bool ifVowel;
            bool ifConsonant;
            string resultString = null;

            foreach (string word in v.Split(' '))
            {
                string wordLoop = word;
                ifConsonant = "bcdfghjklmnpqrstvxzwyuBCDFGHJKLMNPQRSTVXZWYU".IndexOf(wordLoop.Substring(0, 1)) >= 0;
                ifVowel = "aeioAEIO".IndexOf(wordLoop.Substring(0, 1)) >= 0;

                if (ifConsonant == true)
                {

                    while (ifConsonant == true)
                    {
                        string moveLetterToEnd;
                        moveLetterToEnd = wordLoop.Substring(0, 1);
                        wordLoop = wordLoop.Remove(0, 1);
                        wordLoop = wordLoop + moveLetterToEnd;

                        ifConsonant = "bcdfghjklmnpqrstvxzwyuBCDFGHJKLMNPQRSTVXZWYU".IndexOf(wordLoop.Substring(0, 1)) >= 0;
                    }

                }

                ifVowel = "aeioAEIO".IndexOf(wordLoop.Substring(0, 1)) >= 0;


                if (ifVowel == true)
                {
                    wordLoop = wordLoop + "ay";
                }

                resultString = resultString + wordLoop + " ";

            }

            resultString = resultString.TrimEnd();

            return resultString;
        }


    }
}
