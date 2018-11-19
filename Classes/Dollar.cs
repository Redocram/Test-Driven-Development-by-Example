namespace TDDByExample.Classes
{
  public class Dollar : Money
  {
    public Dollar(int amount)
    {
      Amount = amount;
    }

    public new Money Times(int multiplier)
    {
      return new Dollar(Amount * multiplier);
    }
  }
}