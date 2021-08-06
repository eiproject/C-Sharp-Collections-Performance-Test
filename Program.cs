using CollectionsPerformanceTest.Business;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest {
  class Program {
    static string _filePath = @"C:\Lab Formulatrix\CollectionsPerformanceTest\CollectionsPerformanceTest\archive\out.csv";
    static void Main(string[] args) {
      LoopRepository loop = new LoopRepository(_filePath, 1000);
      loop.StartLoop();
      Console.ReadKey();
    }
  }
}
