using System;

public class MainClass
{
    static string[] SplitSentenceOnWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        return words;
    }

    static string ReverseWords(string someSentence)
    {
        string[] words = SplitSentenceOnWords(someSentence);
        string reverseWords = "";

        for (int i = words.Length - 1; i >= 0; i--)
        {
            reverseWords += words[i] + " ";
        }
        return reverseWords;
    }

    static void Main()
    {
        Console.WriteLine("Введите предложение, в котором слова разделены пробелами: ");

        string userSentence = Console.ReadLine();

        string reverseSentence = ReverseWords(userSentence);

        Console.WriteLine(reverseSentence);
    }
}
