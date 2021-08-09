using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class FluentSyntax {
    private string[] _fruits;
    internal FluentSyntax(string[] inputArray) {
      _fruits = inputArray;
      FilterUsingLinq("a").WriteResult();
    }
    private IEnumerable<string> FilterUsingLinq(string word) {
      return _fruits
        .Where(n => n.Contains(word))
        .OrderBy(n => n.Length)
        .Select(n => n.ToUpper());
    }
  }
}
