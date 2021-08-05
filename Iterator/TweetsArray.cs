using System.Collections;
namespace CollectionsPerformanceTest.Business {
  class TweetsArray : TweetsIterator {
    object[] _tweets;
    internal TweetsArray(ArrayList tweets)
      : base() {
      _tweets = tweets.ToArray();
    }

    internal object[] GetTweets() {
      return _tweets;
    }
    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Length; i++) {
        // Do Nothing
      }
    }

  }
}
