namespace Info_Checksum.classes
{
  public class CreditCard
  {
    public string CardNumber { get; }
    public string CardType { get; }
    public bool CardValidation { get; }

    public CreditCard(string cardNumber, string cardType, bool isValid)
    {
      CardNumber = cardNumber;
      CardType = cardType;
      CardValidation = isValid;
    }
  }
}
