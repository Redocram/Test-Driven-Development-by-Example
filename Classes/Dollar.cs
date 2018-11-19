namespace TDDByExample.Classes
{
  public class Dollar : Money
  {
    public Dollar(int amount)
    {
      this.Amount = amount;
    }

    public Money Times(int multiplier)
    {
      return new Dollar(Amount * multiplier);
    }
  }
}