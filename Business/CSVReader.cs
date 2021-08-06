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
  class CSVReader {
    private ArrayList _tweets;
    private StreamReader _csvStreamer;
    protected CsvReader _csvReader;
    internal CSVReader() {
      _tweets = new ArrayList();
    }

    // TODO - Try another file reader 
    internal ArrayList ReadUsingCSVReader(string filePath) {
      _csvStreamer = File.OpenText(filePath);
      _csvReader = new CsvReader(_csvStreamer, new CultureInfo("en-US", false));
      while (_csvReader.Read()) {
        Tweet tweet = _csvReader.GetRecord<Tweet>();
        _tweets.Add(tweet);
      }
      return _tweets;
    }

    internal ArrayList ReadUsingFileReadLines(string filePath) {
      IEnumerable<string> rows = File.ReadLines(filePath);
      foreach (string row in rows.Skip(1)) {
        string[] queryArray = ParseStringToArray(row);
        Tweet tweet = new Tweet() {
          UserName = queryArray[0],
          ScreenName = queryArray[1],
          Location = queryArray[2],
          TweetAt = queryArray[3],
          OriginalTweet = queryArray[4],
          Sentiment = queryArray[5]
        };
        Console.WriteLine(tweet.Sentiment);
        _tweets.Add(tweet);
      }
      return _tweets;
    }

    private string[] ParseStringToArray(string text) {
      string[] validSentiment = new string[] {
        "Negative", "Positive", "Neutral", "Extremely Positive", "Extremely Negative"
      };
      text.Replace(",,", ", ,");
      string[] queryArray = text.Split(',');

      if (queryArray.Length == 6) {
        if (validSentiment.Contains(queryArray[5])) {
          // pass
        }
        else {
          Console.WriteLine(text);
          throw new NotImplementedException("Wrong Sentiment format.");
        }
      }
      else if (queryArray.Length > 6) {
        Console.WriteLine("More than 6");
        IEnumerable<string> taked = queryArray.Take(-1);
        foreach (string take in taked) {
          Console.WriteLine(take);
        }
        Console.WriteLine(queryArray[queryArray.Length -1]);
        Console.ReadKey();
      }
      else if (queryArray.Length < 6) {
        Console.WriteLine("Less than 6");
        Console.WriteLine(text);
        Console.ReadKey();
        Array.Resize(ref queryArray, 6);
      }
      else {
        Console.WriteLine(text);
        throw new NotImplementedException("Something that not expected happen, check 'text' variable.");
      }

      return queryArray;
    }
  }
}
