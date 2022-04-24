using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        string sentence1 = "I am so bored";
        string sentence2 = "This is another sentence.";
        if (CanMakeSentence(sentence1, sentence2))
        {
            Console.WriteLine("Sentence 1 can be made with letters from sentence 2.");
        }
        else
        {
            Console.WriteLine("Sentence 1 can not be made with letters from sentence 2.");
        }
    }
    static bool CanMakeSentence(string sentence1, string sentence2)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (char letter in sentence2)
        {
            if (letters.ContainsKey(letter))
            {
                letters[letter]++;
            }
            else
            {
                letters.Add(letter, 1);
            }
        }
        foreach (char letter in sentence1)
        {
            if (!letters.ContainsKey(letter))
            {
                return false;
            }
            else
            {
                letters[letter]--;
                if (letters[letter] == 0)
                {
                    letters.Remove(letter);
                }
            }
        }
        return true;
        
    }

}




