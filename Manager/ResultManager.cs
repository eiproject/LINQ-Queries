using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  static class ResultManager {
    static int code;
    public static void WriteResult(this IEnumerable<string> inputs) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " ");
      foreach (string input in inputs) {
        Console.Write(input + " ");
      }
      Console.WriteLine();
      code++;
    }

    public static void WriteResult(this List<string> inputs) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " ");
      foreach (string input in inputs) {
        Console.Write(input + " ");
      }
      Console.WriteLine();
      code++;
    }

    public static void WriteResult(this IEnumerable<int> inputs) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " ");
      foreach (int input in inputs) {
        Console.Write(input + " ");
      }
      Console.WriteLine();
      code++;
    }

    public static void WriteResult(this string input) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " ");
      Console.Write(input);
      Console.WriteLine();
      code++;
    }

    public static void WriteResult(this int input) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " "); 
      Console.Write(input);
      Console.WriteLine();
      code++;
    }

    public static void WriteResult(this bool input) {
      Console.Write(code.ChangeNumberingTo2DigitFormatted() + " "); 
      Console.Write(input);
      Console.WriteLine();
      code++;
    }
    
    public static string ChangeNumberingTo2DigitFormatted(this int input) {
      string inputStr = input.ToString();
      if (inputStr.Length == 1) { inputStr = "0" + inputStr; }
      return inputStr;
    } 
  }
}
