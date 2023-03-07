using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        public static Random random = new Random(); //creates the random funnction so it can be used later.

        public static List<Card> CreatePack() //This function creates a list using two arrays; Suits & Ranks.
        {
            List<Card> pack = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" }; // the names of the ranks for the array
            string[] ranks = { "Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };// the value of the cards for ranks

            pack.AddRange(from int suit in suits
                          from int rank in ranks
                          select new Card( suit, rank)); // selects a random suit and a random rank for the Card class

            return pack;
        }

        public static bool shuffleCardPack() //a method that allows the user to select which shuffle method they'd like to use.
        {
            List<Card> cards = new List<Card>();    // creates a new card object to be used in this method.
            Console.WriteLine("Which shuffle method would you like to use?: 1 - The Fiser Yates Shuffle, 2 - The Riffle Shuffle, or 3 - No Shuffle."); // asks the  user which shuffle method theye'd like to use.
            string userResponse = Console.ReadLine(); // reads the user's input to select a shuffle method.
            
            if(userResponse == "1") //calls the Fisher Yates Shuffle method "fisherYatesShuffle()" & deals a card.
            {
               fisherYatesShuffle(cards);
                deal(cards);
            }

            if(userResponse == "2") //calls the Riffle Shuffle Method "riffleShuffleMethod" & Deals a card.
            {
                riffleShuffle(cards);
                deal(cards);
            }

            if(userResponse == "3") //deals a card without using a shuffle method.
            {
                Console.WriteLine("No Shuffle selected");
                deal(cards);
            }

            return true;
        }
        public static List<Card> fisherYatesShuffle(List<Card> cards) // this method uses the fisher yates shuffle algorithm to shuffle the deck of cards.
        {
            //Console.WriteLine("Fisher Yates Called");
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            

            return cards;

        }

        public static List<Card> riffleShuffle(List<Card> cards) //this method uses the riffle shuffle algorithm to shuffle the deck of cards.
        {
            int halfDeck = random.Next(26, 27); //splits the deck in half
            List<Card> topHalf = cards.GetRange(0, halfDeck); // creates the top half of the deck
            List<Card> bottomHalf = cards.GetRange(halfDeck, cards.Count - halfDeck); // creates the bottom half of the deck
            List<Card> shuffledDeck = new List<Card>(); // creates a new object for the shuffled deck

            for (int i = 0; i < topHalf.Count; i++) // this for loop shuffles the deck, then returns the deck after.
            {
                shuffledDeck.Add(topHalf[i]);
                shuffledDeck.Add(bottomHalf[i]);
            }

            return shuffledDeck;
        }
        public static Card deal(List<Card> cards) // this function deals a single card if there are any left in the deck.
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("No Cards left in the Deck");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            
            
            Console.WriteLine(card);
           
            return card;

            
        }
        //public static List<Card> dealCard(int amount)
        //{
            //Deals the number of cards specified by 'amount'
        //}
    }
}
