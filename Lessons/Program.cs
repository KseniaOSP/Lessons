using System;
using System.Linq;

/*
Массивы
 */
namespace Lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'а', 'е', 'и', 'у', 'ё', 'ы', 'ю', 'я', 'о', 'э' };
            char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь'};
            string sentence = Console.ReadLine();
            int vowel = 0;
            int cons = 0;
            int other = 0;
            string lowersentence = sentence.ToLower();
            int len = sentence.Length;
            for (int i = 0; i < len; i++)
            {
                char letter = sentence[i];
                char lowerletter = lowersentence[i];
                LetterClass letterClass;
               
                if (vowels.Any(c => lowerletter == c))
                {
                    vowel++;
                    letterClass = LetterClass.VOWEL;
                }               
                else if (consonants.Any(c => lowerletter == c))
                {
                    cons++;
                    letterClass = LetterClass.CONSONANT;
                }  
                else
                {
                    other++;
                    letterClass = LetterClass.OTHER;
                }

                Console.WriteLine($"{letter}, индекс = {i}, класс = {letterClass}");
            }
            Console.WriteLine($"Гласные = {vowel}, Согласные = {cons}, Прочие знаки = {other}");
            Console.ReadLine();
        }

        enum LetterClass {VOWEL, CONSONANT, OTHER}
    }    
}
