using DeckCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckCard
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF32;
            var cards = Common.Helper.GenerateRandomCardsCollection();
            Console.WriteLine("Initial list cards");
            PrintListCards(cards);
            var cardsSorted = Common.Helper.SortAscending(cards);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sorted list cards");
            PrintListCards(cardsSorted);
        }

        static void PrintListCards(List<CardModel> cards)
        {
            foreach (var card in cards)
            {
                Console.Write(card + " ");
            }
            Console.WriteLine();
        }
    }
}
