namespace Info_Checksum.classes
{
  public class CardValidator
  {
    // Luhn's algorithm
    public bool isValid(string cardNumber)
    {
      int sum = 0;
      
      // sum 1/2 digits*2
      // begin with second to last digit
      for (int i = cardNumber.Length - 2; i >= 0 ; i -= 2)
      {
        int num = int.Parse(cardNumber[i].ToString());

        num *= 2;
        
        // In Luhn algo, if the num*2 > 10
        // Then num = 1 + remainder of num % 10
        // ex : 12 becomes 1 + 2
        if (num > 9) {
          int remainder = num % 10;
          num = remainder + 1;
        }

        sum += num;
      }

      // Sum other digits to initial sum
      for (int i = cardNumber.Length - 1; i >= 0; i -=2)
      {
        int num = int.Parse(cardNumber[i].ToString());

        sum += num;
      }

      // Validate if sum % 10 == 0
      return (sum % 10 == 0);
    }
  }  
}
