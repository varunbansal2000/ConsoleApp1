using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13July_
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jamesBond = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.The character—also known by the code number 007(pronounced 'double-O-seven')—has also been adapted for television, rAdio, comic strip, video games and film.The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth - highest - grossing film series to date, which started in 1962 with Dr.No, starring Sean Connery as Bond.As of 2021, there have been twenty - five films in the Eon Productions series.The most recent Bond film, No Time to Die(2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series.There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again(a 1983 remake of an earlier Eon - produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
            Console.WriteLine("Count of blank spaces: " + jamesBond.countBlankSpaces());
            Console.WriteLine("Count of words : " + jamesBond.countWords());
            Console.Write("Enter the word to search :  ");
            string s = Console.ReadLine();
            Console.WriteLine("Count of word '" + s +"' : " + jamesBond.searchWord(s));
            Console.WriteLine("Count of word 'the' : " + jamesBond.searchWord("the"));
            jamesBond.vowelCount();
            jamesBond.upperCase();
            Console.WriteLine("Count of special chars :" + jamesBond.specialChars());

            Console.ReadLine();
        }

        
    }
    public static class methodExtensions
    {
        public static int countBlankSpaces(this string s)
        {
            int spaceCount = 0;
            foreach (char ch in s)
            {
                if (ch == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }
        public static int countWords(this string s)
        {
            int spaceCount = 0;
            foreach (char ch in s)
            {
                if (ch == ' ')
                    spaceCount++;
            }
            spaceCount++;
            return spaceCount;
        }

        public static int searchWord(this string s, string word)
        {
            //s = s.ToLower();
            //word = word.ToLower();
            int count = 0;
            int a = 0;
            while ((a = s.IndexOf(word, a)) != -1)
            {
                a += word.Length;
                count++;
            }
            return count;
        }

        public static void vowelCount(this string s)
        {
            int acount = 0;
            int ecount = 0;
            int icount = 0;
            int ocount = 0;
            int ucount = 0;
            foreach (char ch in s)
            {
                char c = char.ToLower(ch);
                switch (c)
                {
                    case 'a':
                        acount++;
                        break;
                    case 'e':
                        ecount++;
                        break;
                    case 'i':
                        icount++;
                        break;
                    case 'o':
                        ocount++;
                        break;
                    case 'u':
                        ucount++;
                        break;
                    default:
                        break;
                }


            }
            Console.WriteLine("Total count of a " + acount);
            Console.WriteLine("Total count of e " + ecount);
            Console.WriteLine("Total count of i " + icount);
            Console.WriteLine("Total count of o " + ocount);
            Console.WriteLine("Total count of u " + ucount);
        }

        public static void upperCase(this string s)
        {
            String[] arr = s.Split(' ');
            String newStr = "";
            foreach (string item in arr)
            {
                newStr += char.ToUpper(item[0]);
                newStr += item.Substring(1);
                newStr += " ";
            }
            Console.WriteLine(newStr);
        }

        public static int specialChars(this string s)
        {
            int specialChar = 0;
            foreach (char ch in s)
            {
                if (!(Char.IsLetter(ch) || char.IsDigit(ch) || char.IsWhiteSpace(ch)))
                {
                    Console.Write(ch + " ");
                    specialChar++;
                }
            }
            return specialChar;
        }
    }
}
