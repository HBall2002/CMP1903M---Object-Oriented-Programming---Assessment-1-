using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public int Rank { get; set; } // gets & sets the value of the ranks (11)
        public int Suit { get; set; } // gets & sets the value of the suits (4)

        public Card(int suit, int rank) // creates the card object in the card classs usin the parameters "Rank" & "Suit"
        {
            Suit = suit;
            Rank = rank;
        }

    }
}
