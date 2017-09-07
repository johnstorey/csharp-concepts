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
   public void OrdinalComparisons()
   {
     // "atom" < "Atom"
     var result = System.String.CompareOrdinal("atom", "Atom");
     Assert.False(result < 0, "atom LT Atom");

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

   // Traditional String comparison.
   [Fact]
   public void StandardComparisons()
   {
     // "atom" EQ "Atom"
     var result = System.String.Compare("atom", "Atom");
     Assert.False(result == 0, "atom EQ Atom");

     // "atom" LT "Zambia" !
     result = System.String.Compare("atom", "Zambia");
      Assert.True(result < 0, "atom LT Zambia!");

    // "atom" LT "zambia"
    result = System.String.Compare("atom", "zambia");
    Assert.True(result < 0, "atom LT zambia");

    // "Atom" LT "zambia"
    result = System.String.Compare("Atom", "Zambia");
    Assert.True(result < 0, "Atom LT Zambia");

    // "Atom" EQ "Atom"
    result = System.String.Compare("Atom", "Atom");
    Assert.True(result == 0, "Atom EQ Atom");
   }

   // CompareTo implements IComparable and is *the standard
   // comparison protocol*. This means it defines default
   // ordering behavior of strings in applications such as
   // sorted collections.
   [Fact]
   public void DefaultComparison()
   {
     // "atom" EQ "Atom"
     var result = "atom".CompareTo("Atom");
     Assert.False(result == 0, "atom EQ Atom");

     // "atom" LT "Zambia" !
     result = "atom".CompareTo("Zambia");
      Assert.True(result < 0, "atom LT Zambia!");

    // "atom" LT "zambia"
    result = "atom".CompareTo("zambia");
    Assert.True(result < 0, "atom LT zambia");

    // "Atom" LT "zambia"
    result = "Atom".CompareTo("Zambia");
    Assert.True(result < 0, "Atom LT Zambia");

    // "Atom" EQ "Atom"
    result = "Atom".CompareTo("Atom");
    Assert.True(result == 0, "Atom EQ Atom");
   }
  }
}