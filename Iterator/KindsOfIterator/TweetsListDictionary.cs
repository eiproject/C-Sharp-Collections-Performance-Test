using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CollectionsPerformanceTest.Business {
  class TweetsListDictionary : TweetsIterator {
    ListDictionary _tweets = new ListDictionary();
    internal TweetsListDictionary(ArrayList tweets)
      : base() {
      Console.WriteLine(this.GetType().Name);
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.ID, tweet);
      }
    }

    internal ListDictionary GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
