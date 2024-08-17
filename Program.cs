namespace hangman;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hangman");
        List<string> slova = HangmanGame.nactiSlova();
        List<char> seznamPokusu = new List<char>();
        string skryteSlovo = HangmanGame.vyberNahodneSlovo(slova);
        int pocetDovolenychPokusu = 15;
        int cisloPokusu = 0;
        
        while (cisloPokusu < pocetDovolenychPokusu && !HangmanGame.bylaDosazenaVyhra(skryteSlovo, seznamPokusu))
        {
            cisloPokusu++;
            Console.Clear();            
            //HangmanGame.zakresliGrafiku(i);            
            Console.WriteLine("Již vyzkoušené písmena: " + HangmanGame.vypisPokusu(seznamPokusu));
            Console.WriteLine();            
            Console.WriteLine("Skryté slovo: " + HangmanGame.vypisSlepeSlovo(skryteSlovo, seznamPokusu));
            Console.WriteLine();
            Console.Write("Zadej pismeno ktere chces hadat: "); 
            var cki = Console.ReadKey();
            char guess = cki.KeyChar;
            seznamPokusu.Add(guess);
            Console.WriteLine();
        } 
        
        if (HangmanGame.bylaDosazenaVyhra(skryteSlovo, seznamPokusu))
        {
            Console.WriteLine("Gratulujeme, vyhrál jsi!");
        }
        else 
        {
            Console.WriteLine("Nepovedlo se ti vyhrát. Skryté slovo bylo: {0}", skryteSlovo);
        }
        
    }
}
