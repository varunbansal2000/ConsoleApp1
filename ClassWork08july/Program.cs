using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork08july
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ques2and3();
            Console.Clear();
            ques4();
            Console.Clear();
            ques5and6();
            return;
        }


        static void ques2and3()
        {
            

            int size = 5;
            int[] arr = new int[size];
            
            int index = 0;
            while (true)
            {
                Console.WriteLine("Choose option :");
                Console.WriteLine("1: Add new elemnet.");
                Console.WriteLine("2. Search element.");
                Console.WriteLine("3. Terminate.");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("New Element :");
                        int newEle = Convert.ToInt16(Console.ReadLine());
                        if (index == size)
                        {
                            int[] arr2 = new int[size * 2];

                            for (int i = 0; i < size; i++)
                                arr2[i] = arr[i];
                            size *= 2;
                            arr = arr2;
                        }
                        arr[index] = newEle;
                        index++;
                        Console.WriteLine("Element added sucessfully!");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter element to find :");
                        int x = Convert.ToInt16(Console.ReadLine());
                        int ind = Array.IndexOf(arr, x);
                        if (ind == -1)
                            Console.WriteLine("Not Found!!");
                        else
                            Console.WriteLine("Found at index :" + ind);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                if (option == 3)
                    break;
            }
            Console.ReadLine();
        }
        static void ques4()
        {
            string jamesBond = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.The character—also known by the code number 007(pronounced 'double-O-seven')—has also been adapted for television, rAdio, comic strip, video games and film.The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth - highest - grossing film series to date, which started in 1962 with Dr.No, starring Sean Connery as Bond.As of 2021, there have been twenty - five films in the Eon Productions series.The most recent Bond film, No Time to Die(2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series.There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again(a 1983 remake of an earlier Eon - produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";

            int spaceCount = 0;
            foreach(char ch in jamesBond)
            {
                if (ch == ' ')
                    spaceCount++;
            }
            Console.WriteLine("Total number of spaces in string : " + spaceCount);
            int words = spaceCount + 1;
            Console.WriteLine("Total number of words in string : " + words);
            Console.Write("Enter word to search : ");
            string s = Console.ReadLine();
            int count = 0;
            int a = 0;
            while ((a = jamesBond.IndexOf(s, a)) != -1)
            {
                a += s.Length;
                count++;
            }
            Console.WriteLine("Total occurences of '" + s + "' are " + count);
            int acount = 0;
            int ecount = 0;
            int icount = 0;
            int ocount = 0;
            int ucount = 0;
            foreach (char ch in jamesBond)
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

            String[] arr = jamesBond.Split(' ');
            String newStr = "";
            foreach(string item in arr)
            {
                newStr += char.ToUpper(item[0]);
                newStr += item.Substring(1);
                newStr += " ";
            }
            Console.WriteLine(newStr);

            int specialChar = 0;
            foreach(char ch in jamesBond)
            {
                if (!(Char.IsLetter(ch) || char.IsDigit(ch) || char.IsWhiteSpace(ch)))
                {
                    Console.Write(ch + " ");
                    specialChar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Count of special characters: " + specialChar);
            Console.ReadLine();
        }
        static void ques5and6()
        {
            Console.WriteLine("Array List with integers, characters, strings and decimals!");
            Console.WriteLine();
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(2);
            arr.Add('a');
            arr.Add('b');
            arr.Add("C#");
            arr.Add("UKG");
            arr.Add(3.5);
            arr.Add(10.5);
            int i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(i++ + " : " +item);
            }
            Console.WriteLine();
            Console.WriteLine("List after adding new elements");
            Console.WriteLine();
            arr.Insert(2,"Hi");
            arr.Insert(5, "Ukrew");
            i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(i++ + " : " + item);
            }
            Console.WriteLine(); 
            Console.WriteLine("List after removing elemnts from specific index.");
            Console.WriteLine();
            arr.RemoveAt(0);
            arr.RemoveAt(2);
            i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine(i++ + " : " + item);
            }
            Console.WriteLine();
            Console.WriteLine("Printing only strings.");
            Console.WriteLine();
            foreach (var item in arr)
            {
                if(item.GetType() == typeof(string))
                    Console.WriteLine(item);
            }
            Console.ReadLine();
        } 
    }
}
