using System;

namespace CSharp.Challenges.NumberHelper
{
    internal static class Guard
    {
	    internal static void IsSingleDigit(string number)
	    {
		    if(string.IsNullOrEmpty(number) || number.Trim().Length != 1)
			  throw new Exception("Not single digit");
	    }

	    internal static void IsTwoDigit(string number)
	    {
		    if (string.IsNullOrEmpty(number) || number.Trim().Length != 2)
			    throw new Exception("Not single digit");
	    }
  }
}
