using System;

public class MainClass
{
    static string[] SplitWordsOfSentence(string Sentence)
    {
        string[] wordsOfSentence = Sentence.Split(' ');
        return wordsOfSentence;
    }

    static void PrintWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите предложение, в котором слова разделены пробелами: ");

        string userSentence = Console.ReadLine();
        string[] words = SplitWordsOfSentence(userSentence);
        
        PrintWords(words);
    }
}
