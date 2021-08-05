using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsPerformanceTest.Models;
using CollectionsPerformanceTest.Business;

namespace CollectionsPerformanceTest {
  class CollectionPerformanceTest {
    private string _filePath;
    internal CollectionPerformanceTest(string filePath) {
      _filePath = filePath;
    }
    internal void Run() {
      CoronaTweets csvTweets = new CoronaTweets();
      csvTweets.Read(new StreamReader(_filePath));

      EnumerableTweets coronaTweets = new EnumerableTweets(csvTweets.GetStreamReader());
    }
  }
}
