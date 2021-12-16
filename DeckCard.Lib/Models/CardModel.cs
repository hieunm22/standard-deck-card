namespace DeckCard.Model
{
    public class CardModel
    {
        public int Value { get; set; }
        public CardTypes Type { get; set; }
        public int ValueConvert
        {
            get { return Value + (int)Type * 13; }
        }
        
        public override string ToString()
        {
            // clubs (♧), spades (♤), hearts (♥) and diamonds (♢)
            string typeString = "";
            string valueString;
            switch (Type)
            {
                case CardTypes.Clubs:
                    typeString = "♧";   // clubs
                    break;
                case CardTypes.Spades:
                    typeString = "♤";   // spades
                    break;
                case CardTypes.Hearts:
                    typeString = "♥";   // hearts
                    break;
                case CardTypes.Diamonds:
                    typeString = "♢";   // diamonds
                    break;
            }
            switch (Value)
            {
                case 1:
                    valueString = "A";
                    break;
                case 11:
                    valueString = "J";
                    break;
                case 12:
                    valueString = "Q";
                    break;
                case 13:
                    valueString = "K";
                    break;
                default:
                    valueString = Value.ToString();
                    break;
            }
            return valueString + typeString;
        }
    }
}
