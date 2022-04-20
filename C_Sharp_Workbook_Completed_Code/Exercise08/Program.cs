using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("The sentence\n" + sentence + "\ncontains " + CountVowels(sentence) + " vowels.");
        }

        public static int CountVowels(string sentence)
        {
            /*
             * This code converts a string into am array of characters
             * e.g. the string "Hello, World" would be converted to this array of characters
             *      {'H', 'e', 'l', 'l', 'o', ',' ' ', 'W', 'o', 'r', 'l', 'd'}
             */
            char[] charArray = sentence.ToCharArray();

            /*
             * This array contains the possible vowels (upparcase and lowercase) that will be used to compare each character in the sentence.
             */
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};

            int vowelCounter = 0;

            for(int i=0; i<charArray.Length; i++)
            {
                char currentCharacter = charArray[i];

                /*
                 * The method Array.IndexOf will return an integer representing the position in the array vowels where the currentCharacter is found
                 * If this method cannot find the currentCharacter in the vowels array, this means the currentCharacter is not a vowel.
                 * The method returns -1 if it cannot find the currentCharacter in the vowel array.
                 * 
                 * e.g. if the currentCharacter is found in the vowel array, add 1 to the vowelCounter variable
                 */
                int arrayIndex = Array.IndexOf(vowels, currentCharacter);

                if(arrayIndex > -1)
                {
                    vowelCounter++;
                }
            }

            return vowelCounter;
        }
    }
}
