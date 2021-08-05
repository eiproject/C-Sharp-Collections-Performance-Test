﻿using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CollectionsPerformanceTest.Business {
  class TweetsSortedListWithKeyValue : TweetsIterator {
    SortedList<string, Tweet> _tweets = new SortedList<string, Tweet>();
    internal TweetsSortedListWithKeyValue(ArrayList tweets)
      : base() {
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet.UserName, tweet);
      }
    }

    internal SortedList<string, Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      foreach(var tweet in _tweets) {
        // Do Nothing
      }
    }
  }
}
