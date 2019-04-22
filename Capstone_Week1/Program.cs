using System;

namespace Week1Capstone
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin translator!");
            Console.WriteLine("Enter a word to be translated.");

            string englishWord = EnglishWordEntry();

            string translatedWord = EnglishToPigLatinTranslator(englishWord);

            Console.WriteLine(translatedWord);

            NewTranslation();
        }

        static string EnglishWordEntry()
        {
            string englishWord = Console.ReadLine();

            return englishWord;
        }


        static string EnglishToPigLatinTranslator(string englishWord)
        {
            char[] vowelArray = new char[]{'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'};
            char firstLetter = englishWord[0];
            string restOfWord = englishWord.Substring(1, englishWord.Length -1);
            bool vowel;
            string translatedWord;

            for(var i = 0; i < vowelArray.Length; i++)
            {
                if(firstLetter == vowelArray[i])
                {
                    vowel = true;
                }
                else
                {
                    vowel = false;
                }
            }

            if (vowel == true)
            {
                translatedWord = (englishWord + "ay");
            }
            else
            {
                translatedWord = (restOfWord + firstLetter + "ay");
            }
            return translatedWord;
        }



        static void NewTranslation()
        {
            Console.WriteLine("Would you like to translate another word or sentence? Y or N");
            string again = Console.ReadLine();

            if (again == "Y" || again == "y")
            {
                Console.WriteLine("Welcome to the Pig Latin translator!");
                Console.WriteLine("Enter a word to be translated.");

                string englishWord = EnglishWordEntry();

                string translatedWord = EnglishToPigLatinTranslator(englishWord);

                Console.WriteLine(translatedWord);

                NewTranslation();
            }
            else
            {
                Console.ReadKey();
            }
            
        }
    }
}
