using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Pack(); // creates a new pack object 
            Pack.shuffleCardPack(); // calls the shuffleCardPack method which allows the user to pick a shuffle type, then deals a card to the user using the selected shuffle type 
        }
    }
}
