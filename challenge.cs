//Write a Method that accepts an input from the console,

// and the Method should capitalize the first letter of each word in the string then return the results string.

//eg hello there -  Hello There

// hi - Hi
using System;
class Capitalized
{
    static string CapitalizeFirstLetter(string input)
    {
        if (String.IsNullOrEmpty(input))
            return input;

        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (!String.IsNullOrEmpty(words[i]))
            {
                char[] charArray = words[i].ToCharArray();
                charArray[0] = Char.ToUpper(charArray[0]);
                words[i] = new string(charArray);
            }
        }
        return string.Join(" ", words);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = CapitalizeFirstLetter(input);
        Console.WriteLine("Capitalized: " + result);
    }
}
