using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Models {
  class Tweet {
    private string _userName;
    private string _screenName;
    private string _location;
    private string _tweetAt;
    private string _originalTweet;
    private string _sentiment;

    public string UserName { get { return _userName; } }
    public string ScreenName { get { return _screenName; } }
    public string Location { get { return _location; } }
    public string TweetAt { get { return _tweetAt; } }
    public string OriginalTweet { get { return _originalTweet; } }
    public string Sentiment { get { return _userName; } }

    internal Tweet() { }
    internal void SetUserName(string input) => _userName = input;
    internal void SetScreenName(string input) => _screenName = input;
    internal void SetLocation(string input) => _location = input;
    internal void SetTweetAt(string input) => _tweetAt = input;
    internal void SetSentiment(string input) => _sentiment = input;
  }
}
