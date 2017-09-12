using Xunit;

namespace Concept.UnitTests.ToStringAndParse
{
  /*
   * ToString gives output for all simple value types, and has
   * Parse to reverse the operation.
   * 
   * If parsing fails, a FormatException is thrown.
   */
  public class ToStringAndParse
  {
    [Fact]
    public void BooleanToStringAndParse()
    {
      bool x = true;

      string s = true.ToString();
      int comparison = s.CompareTo("true");
      Assert.True(comparison == 1, "s is 'true'");

      bool b = bool.Parse(s);
      Assert.True(x == b, "b has a value of 'true'");
    }

    /*
     * Many types define TryParse, which returns false if Parse
     * will fail rather than throwing an exception.
     */
    [Fact]
    public void TryParse()
    {
      int i;

      bool failure = int.TryParse("qwerty", out i);
      Assert.True(failure == false, "Invalid parsing fails.");

      bool success = int.TryParse("123", out i);
      Assert.True(success == true, "Valid parsing succeeds.");
    }

    /*
     * Specify an invariant culture to prevent errors where "1.234"
     * does not parse as float in Germany, where '.' is the thousands
     * separator. Hard to see where this would be a bad idea.
     */
     [Fact]
     public void ParseWithInvariantCulture()
     {
       double x = double.Parse("1.234", System.Globalization.CultureInfo.InvariantCulture);
       Assert.True(x == 1.234, "Parse with culture invariant.");
     }
  }
}