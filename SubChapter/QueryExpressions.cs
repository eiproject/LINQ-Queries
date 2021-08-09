using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class QueryExpressions {
    private string[] _fruits;
    internal QueryExpressions(string[] inputArray) {
      _fruits = inputArray;
      FilterUsingQuerySyntax().WriteResult();
      FilterUsingFluentSyntax().WriteResult();
    }

    private IEnumerable<string> FilterUsingQuerySyntax() {
      return from n in _fruits
             where n.Contains("p") // Filter elements
             orderby n // Sort elements
             select n.ToLower(); // Translate each element (project)
    }

    private IEnumerable<string> FilterUsingFluentSyntax() {
      return _fruits
             .Where(n => n.Contains("p")) // Filter elements
             .OrderBy(n => n) // Sort elements
             .Select(n => n.ToLower()); // Translate each element (project)
    }

    private IEnumerable<string> FilterUsingMixed() {
      return (from n in _fruits
              where n.Contains("p") // Filter elements
              select n.ToLower()) // Translate each element (project)
             .OrderBy(n => n); // Sort elements
    }
  }
}
