using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] list = new string[]{"car", "cartouches", "carpet", "cartoonist", "carrot", "cared",
        "carton", "captain", "cartoon", "carter"};
      searchEngine("cartoons", list);
    }

    public static List<string[]> searchEngine(string input, string[] list)
    {
      List<string[]> sortList = new List<string[]>();
      for (int i = 2; i <= input.Length; i++)
      {
        string subInput = input.Substring(0, i);
        var myList = list.Where(word => word.StartsWith(subInput)).ToArray();
        Array.Sort(myList);
        sortList.Add(myList.Take(3).ToArray());
      }
      return sortList;
    }
  }
}