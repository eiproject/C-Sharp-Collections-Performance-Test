using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsHashSet : TweetsIterator {
    HashSet<Tweet> _tweets;
    internal TweetsHashSet(ArrayList tweets)
      : base() {
      Console.WriteLine(this.GetType().Name);
      _tweets = new HashSet<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet);
      }
    }

    internal HashSet<Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
