using System;

namespace CSharp.Challenges.NumberHelper
{
  internal class TensHandler : IUnitHandler
  {
	private static UnitsHandler _unitsHandler;

	internal TensHandler()
	{
	  _unitsHandler = new UnitsHandler();
	}

	public string Convert(string tens)
	{
	  Guard.IsTwoDigit(tens);

	  switch (tens)
	  {
		case "10": return "ten";
		case "11": return "eleven";
		case "12": return "twelve";
		case "13": return "thirteen";
		case "14": return "fourteen";
		case "15": return "fifteen";
		case "16": return "sixteen";
		case "17": return "seventeen";
		case "18": return "eighteen";
		case "19": return "nineteen";
		case "20": return "twenty";
		case "30": return "thirty";
		case "40": return "fourty";
		case "50": return "fifty";
		case "60": return "sixty";
		case "70": return "seventy";
		case "80": return "eighty";
		case "90": return "ninety";
		default: return HandleTwoDigits(tens);
	  }
	}

	private string HandleTwoDigits(string number)
	{
	  var tens = Convert(number[0] + "0");
	  var units = _unitsHandler.Convert(number[1].ToString());
	  return $"{tens} {units}";
	}
  }
}
