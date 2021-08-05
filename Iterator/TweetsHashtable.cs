using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsHashtable : TweetsIterator {
    Hashtable _tweets = new Hashtable();
    internal TweetsHashtable(ArrayList tweets)
      : base() {
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.UserName, tweet);
      }
    }

    internal Hashtable GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
