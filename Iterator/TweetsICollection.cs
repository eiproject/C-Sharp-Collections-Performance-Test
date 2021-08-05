using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsICollection : TweetsIterator {
    ICollection<Tweet> _tweets; 
    internal TweetsICollection(ArrayList tweets)
      : base() {
      _tweets = new List<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet);
      }
    }

    internal List<Tweet> GetTweets() {
      return null;
    }

    internal override void DoLoop() {
      foreach(Tweet tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
