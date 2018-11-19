namespace TDDByExample.Classes
{
  public class Franc : Money
  {
    public Franc(int amount)
    {
      this.Amount = amount;
    }

    public override Money Times(int multiplier)
    {
      return new Franc(Amount * multiplier);
    }
  }
}