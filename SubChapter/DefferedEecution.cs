using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class DefferedEecution {
    internal DefferedEecution(string[] inputArray) {
      DoReevaluation(inputArray.ToList());
      CapturedVariable(inputArray.ToList());
    }

    internal void DoReevaluation(List<string> fruits) {
      IEnumerable<string> query = fruits.Select(n => n.ToUpper());
      // List<string> query = fruits.Select(n => n.ToUpper()).ToList(); // will copy data
      query.WriteResult(); // APPLE MANGO ...
      fruits.Clear();
      query.WriteResult(); // null
    }

    internal void CapturedVariable(List<string> fruits) {
      string pre = "the ";
      IEnumerable<string> query = fruits.Select(n => pre + n);
      query.WriteResult(); // the apple the mango ...
      pre = "a ";
      query.WriteResult(); // a apple a mango ...
    }
  }
}
