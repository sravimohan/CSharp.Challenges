using CSharp.Challenges.NumberHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
  [TestClass]
  public class NumberToWordTests
  {
	[DataTestMethod]
	[DataRow(0, "zero")]
	[DataRow(1, "one")]
	[DataRow(2, "two")]
	[DataRow(3, "three")]
	[DataRow(4, "four")]
	[DataRow(5, "five")]
	[DataRow(6, "six")]
	[DataRow(7, "seven")]
	[DataRow(8, "eight")]
	[DataRow(9, "nine")]
	public void UnitsTest(int number, string expected)
	{
	  //act
	  var actual = number.ToWords();

	  //assert
	  Assert.AreEqual(expected, actual);
	}

	[DataTestMethod]
	[DataRow(10, "ten")]
	[DataRow(11, "eleven")]
	[DataRow(12, "twelve")]
	[DataRow(13, "thirteen")]
	[DataRow(14, "fourteen")]
	[DataRow(15, "fifteen")]
	[DataRow(16, "sixteen")]
	[DataRow(17, "seventeen")]
	[DataRow(18, "eighteen")]
	[DataRow(19, "nineteen")]
	[DataRow(20, "twenty")]
	[DataRow(21, "twenty one")]
	[DataRow(22, "twenty two")]
	[DataRow(23, "twenty three")]
	[DataRow(24, "twenty four")]
	[DataRow(25, "twenty five")]
	[DataRow(26, "twenty six")]
	[DataRow(27, "twenty seven")]
	[DataRow(28, "twenty eight")]
	[DataRow(29, "twenty nine")]
	[DataRow(30, "thirty")]
	[DataRow(40, "fourty")]
	[DataRow(50, "fifty")]
	[DataRow(51, "fifty one")]
	[DataRow(60, "sixty")]
	[DataRow(62, "sixty two")]
	[DataRow(70, "seventy")]
	[DataRow(73, "seventy three")]
	[DataRow(80, "eighty")]
	[DataRow(84, "eighty four")]
	[DataRow(90, "ninety")]
	[DataRow(95, "ninety five")]
	public void TensTest(int number, string expected)
	{
	  //act
	  var actual = number.ToWords();

	  //assert
	  Assert.AreEqual(expected, actual);
	}
  }
}
