using DeckCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckCard.Common
{
    public class Helper
    {
        /// <summary>
        /// generate a shuffered list of standard cards
        /// </summary>
        /// <returns>a standard deck of 52 playing cards that 's shuffered</returns>
        public static List<CardModel> GenerateRandomCardsCollection()
        {
            List<CardModel> cards = new List<CardModel>();

            List<int> orders = Enumerable.Range(1, 52).ToList();

            while (orders.Count > 0)
            {
                // get random index in range of 52 ids
                int randomIndex = new Random().Next(0, orders.Count);
                int randomValue = orders[randomIndex];

                var card = new CardModel();
                card.Value = (randomValue - 1) % 13 + 1;
                card.Type = (CardTypes)((randomValue - 1) / 13);
                cards.Add(card);

                // remove the item at the selected index
                orders.RemoveAt(randomIndex);
            }

            return cards;
        }

        /// <summary>
        /// Sort function <para />
        /// convert every card to an integer number based on their value and type<br />
        /// consider ace = 1, jack = 11, queen = 12, king = 13<br />
        /// and their type: clubs (0), spades (1), hearts (2) and diamonds (3)<br />
        /// so the ValueConvert is a multiple of the number in brackets multiplied by 13<br />
        /// order priority ascending based on their type and then value, from smallest value of type (clubs -> spades -> hearts -> diamonds) and value (1,2,3,...)<br />
        /// for example: 3♤ (3 spades) can convert to value 1*13 + 3 = 16<br />
        ///              8♢ (8 diamonds) can convert to value 3*13 + 8 = 47
        /// </summary>
        /// <param name="cards">input card list</param>
        /// <returns>output card list with ascending order</returns>
        public static List<CardModel> SortAscending(List<CardModel> cards)
        {
            // order the list cards follow by ValueConvert field
            cards.Sort((a, b) => a.ValueConvert - b.ValueConvert);

            return cards;
        }
    }
}
