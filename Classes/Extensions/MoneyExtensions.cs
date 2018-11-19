namespace TDDByExample.Classes.Extensions
{
  public class MoneyExtensions
  {
    public static Dollar Dollar(int amount)
    {
      return new Dollar(amount);
    }
  }
}