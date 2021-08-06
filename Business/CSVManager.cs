using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class CSVManager {
    private ArrayList _tweets;
    private StreamReader _csvStreamer;
    protected CsvReader _csvReader;
    internal CSVManager() {
      _tweets = new ArrayList();
    }

    // TODO - Try another file reader 
    internal ArrayList ReadUsingCSVReader(string filePath) {
      _csvStreamer = File.OpenText(filePath);
      _csvReader = new CsvReader(_csvStreamer, new CultureInfo("en-US", false));
      while (_csvReader.Read()) {
        dynamic obj = _csvReader.GetRecord<object>();
        string[] queryArray = DynamicObjectToArray(obj);
        Tweet tweet = new Tweet(queryArray);
        _tweets.Add(tweet);
      }
      return _tweets;
    }

    internal ArrayList ReadUsingFileReadLines(string filePath) {
      IEnumerable<string> rows = File.ReadLines(filePath);
      foreach (string row in rows.Skip(1)) {
        string[] queryArray = ParseStringToArray(row);
        try {
          Tweet tweet = new Tweet(queryArray);
          _tweets.Add(tweet);
        }
        catch (Exception createTweetObjectFailed){
          // Console.WriteLine($"{queryArray[0]} Message: { createTweetObjectFailed } ");
        }
        
      }
      return _tweets;
    }

    // outputnya List of string System.IO, File.ReadAllText

    private string[] ParseStringToArray(string text) {
      text.Replace(",,", ", ,");
      string[] queryArray = text.Split(',');
      return queryArray;
    }

    private string[] DynamicObjectToArray(dynamic obj) {
      string[] queryArray = new string[] {
        obj.ID, obj.lang, obj.Date, obj.Source, obj.len, obj.Tweet, obj.Likes, obj.RTs, obj.Hashtags, obj.UserMentionNames, obj.UserMentionID, obj.Name, obj.Place, obj.Followers, obj.Friends
      };
      return queryArray;
    }
  }
}
