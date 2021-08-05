using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Models {
  class Tweet {
    public string UserName { get; set; }
    public string ScreenName { get; set; }
    public string Location { get; set; }
    public string TweetAt { get; set; }
    public string OriginalTweet { get; set; }
    public string Sentiment { get; set; }
  }
}
