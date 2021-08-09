using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  static class LinqQuery {
    public static void WriteResult(this IEnumerable<string> results) {
      foreach (string result in results) {
        Console.WriteLine(result);
      }
      Console.WriteLine("");
    }
  }
}
