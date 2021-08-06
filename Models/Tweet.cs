using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Models {
  class Tweet {
    public string ID { get; set; }
    public string lang { get; set; }
    public string Date { get; set; }
    public string Source { get; set; }
    public string Len { get; set; }
    public string FullText { get; set; }
    public string Likes { get; set; }
    public string RTs { get; set; }
    public string Hashtags { get; set; }
    public string UserMentionNames { get; set; }
    public string UserMentionID { get; set; }
    public string Name { get; set; }
    public string Place { get; set; }
    public string Followers { get; set; }
    public string Friends { get; set; }
  }
}
