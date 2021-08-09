using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class FluentSyntax {
    private string[] _fruits;
    private IEnumerable<string> _filteredFruit;
    internal FluentSyntax(string[] inputArray) {
      _fruits = inputArray;
      FilterUsingLinq("a").WriteResult();
      OrderByNaturalOrdering();
      OtherOperator();
    }
    private IEnumerable<string> FilterUsingLinq(string word) {
      _filteredFruit = _fruits
        .Where(n => n.Contains(word))
        .OrderBy(n => n.Length)
        .Select(n => n.ToUpper());

      return _filteredFruit;
    }
    private void OrderByNaturalOrdering() {
      _filteredFruit.Take(3).WriteResult();
      _filteredFruit.Skip(3).WriteResult();
      _filteredFruit.Reverse().WriteResult();
    }
    private void OtherOperator() {
      _filteredFruit.First().WriteResult();
      _filteredFruit.Last().WriteResult();
      _filteredFruit.Count().WriteResult();
      _filteredFruit.Min().WriteResult();
      _filteredFruit.Contains("APPLE").WriteResult();

      int[] seq1 = { 1, 2, 3 };
      int[] seq2 = { 3, 4, 5 };
      seq1.Concat(seq2).WriteResult();
      seq1.Union(seq2).WriteResult();
    }
  }
}
