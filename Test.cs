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

    [TestCase(new int[] { 0, 0, 1, 0, 1, 0, 0, 1, 0 }, 5)]
    [TestCase(new int[] { 0, 1, 1, 0, 1, 0, 0, 1, 0 }, -1)]
    [TestCase(new int[] { 0, 0, 1, 0, 0, 1, 0, 1 }, 5)]
    public void TestMineField(int[] input, int eq)
    {
      Assert.AreEqual(eq, MyApp.Program.mineField(input));
    }

    [TestCase(new int[] { 1, 2, 3, 4, -5, 6, 7, 8, 9, 10 }, 3, 22)]
    public void TestLargestSumInSubarrays(int[] input, int n, int eq)
    {
      Assert.AreEqual(eq, MyApp.Program.largestSumInSubarrays(input, n));
    }

    [TestCase(8, 21)]
    public void Testrabbits(int n, int eq)
    {
      Assert.AreEqual(eq, MyApp.Program.rabbits(n));

    }

  }
}
