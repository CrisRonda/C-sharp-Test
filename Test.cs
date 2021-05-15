using System.Collections.Generic;
using NUnit.Framework;
namespace MyApp
{

  [TestFixture]
  public class Test
  {
    [SetUp]
    public void setUp() { }
    [Test]
    public void TestingSearEngine()
    {
      string[] list = new string[]{"car", "cartouches", "carpet", "cartoonist", "carrot", "cared",
        "carton", "captain", "cartoon", "carter"};

      List<string[]> exampleList = new List<string[]>(){
      new string[] { "captain", "car", "cared" },
      new string[] { "car", "cared", "carpet" },
      new string[] { "carter", "carton", "cartoon" },
      new string[] { "carton", "cartoon", "cartoonist" },
      new string[] { "cartoon", "cartoonist" },
      new string[] { "cartoon", "cartoonist" },
      new string[0],
      };
      CollectionAssert.AreEqual(exampleList, MyApp.Program.searchEngine("cartoons", list));
    }

    [Test]
    public void TestSortListBySecondTerm()
    {
      int[] input = new int[] { 1, 10, 20, 33, 13, 60, 92, 100, 21 };
      int[] expect = new int[] { 100, 10, 20, 60, 1, 21, 92, 13, 33 };
      CollectionAssert.AreEqual(expect, MyApp.Program.sortListBySecondTerm(input));
    }

  }
}
