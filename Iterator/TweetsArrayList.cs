using CollectionsPerformanceTest.Models;
using System.Collections;

namespace CollectionsPerformanceTest.Business {
  class TweetsArrayList : TweetsIterator {
    ArrayList _tweets;
    internal TweetsArrayList(ArrayList tweets)
      : base() {
      _tweets = tweets;
    }

    internal ArrayList GetTweets() {
      return _tweets;
    }
    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }

  }
}
