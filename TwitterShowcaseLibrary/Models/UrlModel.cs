using System.Runtime.Serialization;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class UrlModel
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "expanded_url")]
        public string ExpandedUrl { get; set; }
        [DataMember(Name = "display_url")]
        public string DisplayUrl { get; set; }
    }

}
