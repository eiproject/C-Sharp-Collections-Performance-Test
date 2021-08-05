using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class EnumerableTweets : IEnumerable {
    CoronaTweet _coronaTweet;
    internal EnumerableTweets(CoronaTweet coronaTweetObject) {
    _coronaTweet = coronaTweetObject;
    }

    IEnumerator IEnumerable.GetEnumerator() {
      throw new NotImplementedException();
    }
  }
}
