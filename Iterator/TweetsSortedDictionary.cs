using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CollectionsPerformanceTest.Business {
  class TweetsSortedDictionary : TweetsIterator {
    SortedDictionary<string, Tweet> _tweets = new SortedDictionary<string, Tweet>();
    internal TweetsSortedDictionary(ArrayList tweets)
      : base() {
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.UserName, tweet);
      }
    }

    internal SortedDictionary<string, Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
