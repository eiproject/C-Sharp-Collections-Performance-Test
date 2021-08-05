using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class EnumerableTweets : IEnumerable {
    StreamReader _coronaTweet;

    internal EnumerableTweets(StreamReader coronaTweets) {
    _coronaTweet = coronaTweets;
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return (IEnumerator)GetEnumeratorTweets();
    }

    internal EnumeratorTweets GetEnumeratorTweets() {
      return new EnumeratorTweets();
    }
  }
}
