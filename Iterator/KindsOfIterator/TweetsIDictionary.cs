using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsIDictionary : TweetsIterator {
    IDictionary<string, Tweet> _tweets = new Dictionary<string, Tweet>();
    internal TweetsIDictionary(ArrayList tweets)
      : base() {
      Console.WriteLine(this.GetType().Name);
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.ID, tweet);
      }
    }

    internal IDictionary<string, Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
