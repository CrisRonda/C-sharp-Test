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
      // int[] input = new int[] { 0, 0, 1, 0, 1, 0, 0, 1, 0 };
      // mineField(input);
      int[] input = new int[] { 1, 2, 3, 4, -5, 6, 7, 8, 9, 10 };
      largestSumInSubarrays(input, 3);

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

    public static int mineField(int[] listFileds)
    {
      int noWay = -1;
      int[] stepList = new int[] { };
      int accOneStep = 0;
      int accTwoStep = 0;

      for (int i = 0; i < listFileds.Length - 1; i++)
      {
        var currentItem = listFileds[i];
        var nextItem = listFileds[i + 1];
        if (nextItem == 1 & currentItem == 1)
        {
          return noWay;
        }
        if (nextItem == 0 & currentItem == 0)
        {
          accTwoStep++;
        }
        if (nextItem == 1 & currentItem == 0)
        {
          accOneStep++;
        }

      }

      return accOneStep + accTwoStep;
    }

    public static int largestSumInSubarrays(int[] listNumbers, int steps)
    {
      var totalItems = listNumbers.Length;
      if (steps > totalItems)
        return -1;

      int index = 0;
      List<int> sumSequences = new List<int>();
      while (index < steps)
      {
        List<int> subarray = new List<int>();
        for (int i = 0; i < totalItems; i++)
        {
          var indexFormula = i * steps + index;
          if (indexFormula < totalItems)
            subarray.Add(listNumbers[indexFormula]);
        }
        sumSequences.Add(subarray.Sum());
        index++;
      }

      return sumSequences.Max();
    }
  }
}