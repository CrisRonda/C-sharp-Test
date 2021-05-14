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

      List<string[]> exampleList = new List<string[]>();
      exampleList.Add(new string[] { "captain", "car", "cared" });
      exampleList.Add(new string[] { "car", "cared", "carpet" });
      exampleList.Add(new string[] { "carter", "carton", "cartoon" });
      exampleList.Add(new string[] { "carton", "cartoon", "cartoonist" });
      exampleList.Add(new string[] { "cartoon", "cartoonist" });
      exampleList.Add(new string[] { "cartoon", "cartoonist" });
      exampleList.Add(new string[0] { });
      CollectionAssert.AreEqual(exampleList, MyApp.Program.searchEngine("cartoons", list));
    }

  }
}
