using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen

        public static void Question1()
        {
            int[] coordinates = new int[3] {1,2,4};
            foreach (int coordinate in coordinates)
            {
                Console.WriteLine(coordinate);
            }
        }
      
        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 

        public static void Question2()        
        {
            byte[] helloInBytes = new byte[5] { 0b01101000, 0b01100101, 0b01101100, 0b01101100, 0b01101111 };
            string chineseHello = "你好";
            string englishHello = "Hello";
            byte[] chineseHelloInBytes = Encoding.UTF8.GetBytes(chineseHello);
            byte[] englishHelloInBytes = Encoding.UTF8.GetBytes(englishHello);
            Console.WriteLine(Encoding.UTF8.GetString(helloInBytes));
            foreach (byte c in englishHelloInBytes)
            {
                Console.WriteLine(Convert.ToString(c,2));
            }
            foreach (byte c in chineseHelloInBytes)
            {
                Console.WriteLine(Convert.ToString(c,2));
            }

            

        }

        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out
        public static void Question3()
        {
            double[] temperatures = new double[4] {20,19,23,30};
            Array.Sort(temperatures);
            foreach (double d in temperatures) { Console.Write($"{d} "); }
            Console.WriteLine($"\nMin:{temperatures[0]}\nMax:{temperatures[temperatures.Length-1]}\nAvg:{temperatures.Sum()/temperatures.Length}");
            
        }


        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out     

        public static void Question4()
        {
            var List = new List<Tuple<string, string, DateOnly>>
            {
                new Tuple<string,string,DateOnly>("bob","smith", new DateOnly(2011,01,22)),
                new Tuple<string, string, DateOnly>("alice", "ledger", new DateOnly(2001, 01, 22)),
                new Tuple<string, string, DateOnly>("reginald", "mould", new DateOnly(2013, 03, 29))
            };
            DateOnly oldestDate = DateOnly.FromDateTime(DateTime.Now);
            string oldest = "null";
            DateOnly youngestDate = DateOnly.FromDateTime(DateTime.MinValue);
            string youngest = "null";
            int counter = 0;
            foreach (Tuple<string,string, DateOnly> student in List)
            {
                if (student.Item3 < oldestDate)
                {
                    oldestDate = student.Item3;
                    oldest = student.Item1;
                }
            }
            foreach (Tuple<string, string, DateOnly> student in List)
            {
                if (student.Item3 > youngestDate)
                {
                    youngestDate = student.Item3;
                    youngest = student.Item1;
                }
            }
            foreach (Tuple<string, string, DateOnly> student in List)
            {
                if (student.Item3 > new DateOnly(2011, 1, 1))
                {
                    counter++;
                }
            }
                Console.WriteLine($"the youngest is: {youngest} (born:{youngestDate})\nthe oldest is: {oldest} (born:{oldestDate})\nstudents born after 2010: {counter}");

        }

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.
        public static string PigLatin(string input)
        {
            List<string> inputList = input.Split(" ").ToList();
            StringBuilder output = new StringBuilder();
            foreach (string word in inputList)
            {
                output.Append($"{word.Remove(0, 1)}{word.Remove(1,word.Length-1)}ay ");
            }
            return output.ToString();
        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
