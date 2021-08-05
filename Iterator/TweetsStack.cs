using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsQueue : TweetsIterator {
    Queue<Tweet> _tweets;
    internal TweetsQueue(ArrayList tweets)
      : base() {
      _tweets = new Queue<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.Enqueue(tweet);
      }
    }

    internal Queue<Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
