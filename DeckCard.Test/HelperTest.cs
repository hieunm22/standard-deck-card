using DeckCard.Common;
using NUnit.Framework;

namespace DeckCard.Test
{
    public class Tests
    {
        [Test]
        public void GenerateRandomCardsCollectionTest()
        {
            // test for generation process returns a 52 items list
            var cardsV1 = Helper.GenerateRandomCardsCollection();
            Assert.AreEqual(52, cardsV1.Count);

            // test for another generation process returns a 52 items list
            var cardsV2 = Helper.GenerateRandomCardsCollection();
            Assert.AreEqual(52, cardsV2.Count);

            // compare 2 lists that must not be same
            var joinV1 = string.Join("_", cardsV1);
            var joinV2 = string.Join("_", cardsV2);
            Assert.AreNotEqual(joinV1, joinV2);

            // test for another generation process returns a 52 items list
            var cardsV3 = Helper.GenerateRandomCardsCollection();
            Assert.AreEqual(52, cardsV3.Count);

            // compare current with 2 previous lists that must not be same
            var joinV3 = string.Join("_", cardsV3);
            Assert.AreNotEqual(joinV3, joinV2);
            Assert.AreNotEqual(joinV3, joinV1);
        }

        [Test]
        public void SortAscendingTest()
        {
            var cards = Helper.GenerateRandomCardsCollection();

            var cardsSort = Helper.SortAscending(cards);
            // get 2 random cards in 2 consecutive positions
            var cardsSortSmall = cardsSort[3];
            var cardsSortBig = cardsSort[4];

            // 4 clubs < 5 clubs (same type and values are different)
            Assert.IsTrue(cardsSortSmall.ValueConvert < cardsSortBig.ValueConvert);

            // get 2 random cards in 2 random positions
            cardsSortSmall = cardsSort[15]; // 3 spades
            cardsSortBig = cardsSort[38];   // K(ing) hearts

            // the card in smaller index is also "smaller" than the one in bigger index
            Assert.IsTrue(cardsSortSmall.ValueConvert < cardsSortBig.ValueConvert);

            cardsSortSmall = cardsSort[12];
            cardsSortBig = cardsSort[13];
            // K clubs (Value of King = 13 but Type = clubs) < A spades (Value of Ace = 1 but Type = spades)
            Assert.IsTrue(cardsSortSmall.ValueConvert < cardsSortBig.ValueConvert);
        }
    }
}