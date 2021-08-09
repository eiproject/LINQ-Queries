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
      FilterByLengthUsingLinq(6).WriteResult();
      FilterByLengthManual(6).WriteResult();
    }

    private IEnumerable<string> FilterByLengthUsingLinq(int length) {
      return _fruits.Where(n => n.Length >= length);
    }

    private IEnumerable<string> FilterByLengthManual(int length) {
      return from n in _fruits
             where n.Length >= length
             select n;
    }

  }
}
