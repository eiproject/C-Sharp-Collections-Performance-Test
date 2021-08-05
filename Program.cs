using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest {
  class Program {
    static string _filePath = @"C:\Lab Formulatrix\CollectionsPerformanceTest\CollectionsPerformanceTest\archive\Corona_NLP_train.csv";
    static void Main(string[] args) {
      LoopTest loop = new LoopTest();
      loop.StartLoop(_filePath, 20);
      loop.PrintAverage();
      Console.ReadKey();
    }
  }
}
