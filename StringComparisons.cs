using Xunit;

namespace Concept.UnitTests.String
{
  public class StringComparisons
  {
   /*
    * Ordinal string comparison relies on Unicode values, and orders by
    * uppercase, then lowercase.
    */    
   [Fact]
   public void OrdinalComparisonByUpperCaseThenLowerCase()
   {
     // "atom" > "Atom"
     var result = System.String.CompareOrdinal("atom", "Atom");
     Assert.False(result < 0, "atom GT Atom");

     // "atom" GT "Zambia" !
     result = System.String.CompareOrdinal("atom", "Zambia");
      Assert.True(result > 0, "atom GT Zambia!");

    // "atom" LT "zambia"
    result = System.String.CompareOrdinal("atom", "zambia");
    Assert.True(result < 0, "atom LT zambia");

    // "Atom" LT "zambia"
    result = System.String.CompareOrdinal("Atom", "Zambia");
    Assert.True(result < 0, "Atom LT Zambia");

    // "Atom" EQ "Atom"
    result = System.String.CompareOrdinal("Atom", "Atom");
    Assert.True(result == 0, "Atom EQ Atom");
   }
  }
}