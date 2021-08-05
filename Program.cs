using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest {
  class Program {
    static string _filePath = @"C:\Lab Formulatrix\CollectionsPerformanceTest\CollectionsPerformanceTest\archive\Corona_NLP_train.csv";
    static void Main(string[] args) {
      CollectionPerformanceTest app = new CollectionPerformanceTest(_filePath);
      app.Run();
    }
  }
}
