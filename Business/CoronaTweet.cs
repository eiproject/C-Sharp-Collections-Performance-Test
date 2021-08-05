using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class CoronaTweet {
    private string _csvFilePath;
    private StreamReader _csvData;
    internal CoronaTweet() {
    }
    internal void Read(string filePath) {
      _csvFilePath = filePath;
      _csvData = new StreamReader($@"{ _csvFilePath }");
    }
    internal StreamReader GetStreamReader() {
      return _csvData;
    }
  }
}
