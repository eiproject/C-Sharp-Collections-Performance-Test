using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CollectionsPerformanceTest.Business {
  class TweetsOrderedDictionary : TweetsIterator {
    OrderedDictionary _tweets = new OrderedDictionary();
    internal TweetsOrderedDictionary(ArrayList tweets)
      : base() {
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.UserName, tweet);
      }
    }

    internal OrderedDictionary GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
