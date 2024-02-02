using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Card
{
    private string Face { get; } // Card's face ("Ace", "Deuce", ...)
    private string Suit { get; } // Card's suit ("Hearts", "Diamonds", ...)

    // Two-parameter constructor initializes card's Face and Suit
    public Card(string face, string suit)
    {
        Face = face; // initialize face of card
        Suit = suit; // initialize suit of card
    }

    // Return string representation of Card
    public override string ToString()
    {
        return $"{Face} of {Suit}";
    }
}

class Program
{
    static void Main()
    {
        Card myCard = new Card("Ace", "Hearts");
        Console.WriteLine(myCard.ToString());
        Console.ReadLine();
    }
    
}
