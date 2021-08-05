using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsList : TweetsIterator {
    List<Tweet> _tweets;
    internal TweetsList(ArrayList tweets)
      : base() {
      _tweets = new List<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet);
      }
    }

    internal List<Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
