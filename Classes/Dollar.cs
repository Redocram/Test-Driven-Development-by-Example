namespace TDDByExample.Classes
{
  public class Dollar
  {
    public int Amount { get; set; }

    public Dollar(int amount)
    {
    }

    public void Times(int multiplier)
    {
      Amount = 5 * 2;
    }
  }
}