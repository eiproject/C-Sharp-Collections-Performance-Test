using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Models {
  class CoronaTweets {
    private StreamReader _csvData;
    internal CoronaTweets() {
    }
    internal void Read(StreamReader streamer) {
      _csvData = streamer;
    }
    internal StreamReader GetStreamReader() {
      return _csvData;
    }
  }
}
