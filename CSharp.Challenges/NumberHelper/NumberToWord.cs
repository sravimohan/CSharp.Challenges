namespace CSharp.Challenges.NumberHelper
{
  public static class NumberToWord
  {
	private static readonly UnitsHandler UnitsHandler;
	private static readonly TensHandler TensHandler;

	static NumberToWord()
	{
	  UnitsHandler = new UnitsHandler();
	  TensHandler = new TensHandler();
	}

	public static string ToWords(this int number)
	{
	  var numberString = number.ToString();

	  if (numberString.Trim().Length == 1)
	  {
		return UnitsHandler.Convert(numberString);
	  }
	  else
	  {
		return TensHandler.Convert(numberString);
	  }
	}
  }
}
