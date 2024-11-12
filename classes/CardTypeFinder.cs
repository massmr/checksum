namespace Info_Checksum.classes
{
  public class CardTypeFinder
  {
    public string FindCardType(string cardNumber)
    {
      // Each bank has its own number length
      int cardNumberLen = cardNumber.Length;

      // Each bank has its own prefix
      // Some banks have 2 digits prefix, like mastercard
      // Check prefix and length
      if(cardNumber.StartsWith("4") && (cardNumberLen >= 13 && cardNumberLen <= 16))
      {
        return "Visa";
      }
      else if(cardNumber.StartsWith("5") && cardNumberLen == 16)
      {
        int completePrefix = int.Parse(cardNumber.Substring(0, 2));
        if (completePrefix >= 51 && completePrefix <= 55)
        {
          return "MasterCard";
        }
      }
      else if((cardNumber.StartsWith("34") || cardNumber.StartsWith("35")) && cardNumberLen == 15)
      {
        return "American Express";
      }
      return "Type not recognised";
    }
  }
}
