using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsIList : TweetsIterator {
    IList<object> _tweets; 
    internal TweetsIList(ArrayList tweets)
      : base() {
      _tweets = tweets.ToArray();
    }

    internal List<object> GetTweets() {
      return null;
    }

    internal override void DoLoop() {
      foreach(object tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
