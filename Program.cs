using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {

      // string[] list = new string[]{"car", "cartouches", "carpet", "cartoonist", "carrot", "cared",
      //   "carton", "captain", "cartoon", "carter"};
      // searchEngine("cartoons", list);
      // sortListBySecond terms
      // int[] input = new int[] { 1, 10, 20, 33, 13, 60, 92, 100, 21 };
      // sortListBySecondTerm(input);
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

    public static int[] sortListBySecondTerm(int[] listNumber)
    {
      int[] result = new int[] { };
      List<string> newList = listNumber.ToList().ConvertAll<string>(item => String.Join("", item.ToString().ToCharArray().Reverse()));
      newList.Sort();
      return newList.ConvertAll<int>(word => Int32.Parse(String.Join("", word.ToCharArray().Reverse()))).ToArray();
    }
  }
}