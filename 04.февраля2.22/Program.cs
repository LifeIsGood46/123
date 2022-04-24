 
using System;
internal class Program
{
    static void Main(string[] args)
    {
        string[] nouns = new string[2];
        string[] verbs = new string[2];
        string[] adjectives = new string[2];
        string[] nouns2 = new string[2];
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter noun in nominative case:");
            nouns[i] = Console.ReadLine();
            Console.WriteLine("Enter verb:");
            verbs[i] = Console.ReadLine();
            Console.WriteLine("Enter adjective:");
            adjectives[i] = Console.ReadLine();
            Console.WriteLine("Enter noun in genitive case:");
            nouns2[i] = Console.ReadLine();
        }
        Random rnd = new Random();
        int rndNoun = rnd.Next(0, 2);
        int rndVerb = rnd.Next(0, 2);
        int rndAdjective = rnd.Next(0, 2);
        int rndNoun2 = rnd.Next(0, 2);
        Console.WriteLine("{0} {1} {2} {3}", nouns[rndNoun], verbs[rndVerb], adjectives[rndAdjective], nouns2[rndNoun2]);
    }
}

