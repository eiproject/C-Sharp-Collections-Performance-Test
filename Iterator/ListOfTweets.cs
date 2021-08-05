using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class ListOfTweets {
    List<Tweet> _tweets = new List<Tweet>();
    
    internal ListOfTweets(CsvReader csvReader) {
      

      while (csvReader.Read()) {
        Tweet tweet = csvReader.GetRecord<Tweet>();
        _tweets.Add(tweet);
      }
    }
    internal List<Tweet> GetTweets() {
      return _tweets;
    }
  }
}
