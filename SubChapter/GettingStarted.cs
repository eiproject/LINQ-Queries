using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class GettingStarted {
    private string[] _fruits;
    private IEnumerable<string> _filteredFruit;

    internal GettingStarted(string[] inputArray) {
      _fruits = inputArray;
      _fruits.WriteResult();
      FilterUsingFluentSyntax(6).WriteResult();
      FilterUsingQuerySyntax(6).WriteResult();
    }

    private IEnumerable<string> FilterUsingFluentSyntax(int length) {
      _filteredFruit = _fruits.Where(n => n.Length >= length);
      return _filteredFruit;
    }

    private IEnumerable<string> FilterUsingQuerySyntax(int length) {
      _filteredFruit = from n in _fruits
                       where n.Length >= length
                       select n;
      return _filteredFruit;
    }

  }
}
