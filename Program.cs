using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries {
  class Program {
    static void Main(string[] args) {


      string[] _fruits = new string[] {
        "apple", "mango", "pinneaple", "melon",
        "pear", "orange", "banana", "rambutan"
      };
      GettingStarted started = new GettingStarted(_fruits);
      Console.ReadKey();
    }
  }
}
