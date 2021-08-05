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
      foreach (Tweet tweet in _tweets) {
        // Do Nothing
      }
    }

  }
}
