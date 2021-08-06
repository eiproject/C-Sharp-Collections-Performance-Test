using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsIReadOnlyList : TweetsIterator {
    IReadOnlyList<object> _tweets; 
    internal TweetsIReadOnlyList(ArrayList tweets)
      : base() {
      Console.WriteLine(this.GetType().Name);
      _tweets = tweets.ToArray();
    }

    internal List<object> GetTweets() {
      return null;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
