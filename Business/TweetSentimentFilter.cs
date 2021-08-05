using CollectionsPerformanceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class TweetSentimentFilter {
    private bool _boolResult;
    internal TweetSentimentFilter() {

    }
    internal bool FilterBySentiment(Tweet tweet, string sentiment){
      if (tweet.Sentiment.ToLower() == sentiment.ToLower()) {
        _boolResult = true;
      }
      else {
        _boolResult = false;
      }
      return _boolResult;
    }
  }
}
