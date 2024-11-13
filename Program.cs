using System;
using Info_Checksum.classes;
using System.Text.RegularExpressions;

namespace Info_Checksum
{
  class Program
  {
    static void Main(string[] args)
    {
      string cardNumber = "";

      // Check if args contains card number
      // Check Length and format
      // Store card number
      if (args.Length >= 1) 
      {
        Console.WriteLine("Checking card number...");
        if (args[0].Length < 13 || args[0].Length > 16 || !Regex.IsMatch(args[0], @"^\d+$"))
        {
          Console.WriteLine("Incorrect format");
          return;
        }
        cardNumber = args[0];
      }
      else
      {
        Console.WriteLine("Please run : dotnet run [your-card-number]");
        return;
      }

      // Create finder instance, and determine card type
      CardTypeFinder finder = new CardTypeFinder();
      string cardType = finder.FindCardType(cardNumber);

      // Create isValid instance and determine number validation
      CardValidator validator = new CardValidator();
      bool isValid = validator.isValid(cardNumber);

      // Create CreditCard instance and store card data
      CreditCard creditCard = new CreditCard(cardNumber, cardType, isValid);

      // Display data
      Console.WriteLine($"Numéro de carte : {creditCard.CardNumber}");
      Console.WriteLine($"Validité : {creditCard.CardValidation}");
      if (creditCard.CardValidation == true)
      {
        Console.WriteLine($"Type de carte : {creditCard.CardType}");
      }
    }
  }
}
