using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Card class represents a playing card with a face and a suit
class Card
{
    public string Face { get; } // Card's face ("Ace", "Deuce", ...)
    public string Suit { get; } // Card's suit ("Hearts", "Diamonds", ...)

    // Two-parameter constructor initializes card's Face and Suit
    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    // Return string representation of Card
    public override string ToString()
    {
        return $"{Face} of {Suit}";
    }
}

// DeckOfCards class represents a deck of playing cards
class DeckOfCards
{
    private static Random randomNumbers = new Random(); // create one Random object to share among DeckOfCards objects
    private const int NumberOfCards = 52; // number of cards in a deck
    private Card[] deck = new Card[NumberOfCards]; // array to store Card objects
    private int currentCard = 0; // index of next Card to be dealt (0-51)

    // Constructor fills deck of Cards
    public DeckOfCards()
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        // Populate deck with Card objects
        for (var count = 0; count < deck.Length; ++count)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
    }

    // Shuffle deck of Cards with one-pass algorithm
    public void Shuffle()
    {
        currentCard = 0; // reinitialize currentCard after shuffling

        // For each card, pick another random card and swap them
        for (var first = 
            
            
            0; first < deck.Length; ++first)
        {
            var second = randomNumbers.Next(NumberOfCards); // select a random number between 0 and 51

            // Swap current Card with randomly selected Card
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    // Deal one Card
    public Card DealCard()
    {
        // Determine whether Cards remain to be dealt
        if (currentCard < deck.Length)
        {
            return deck[currentCard++];
        }
        else
        {
            // Indicate that all Cards were dealt
            return null;
        }
    }
}



    class DeckOfCardsTest
    {
        static void Main()
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();

            // 52 Cards in the order they are dealt
            for (var i = 0; i < 52; ++i)
            {
                Console.Write($"{myDeckOfCards.DealCard(),-19}");

                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }


