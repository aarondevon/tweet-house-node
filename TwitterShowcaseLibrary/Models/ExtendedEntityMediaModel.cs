using System.Runtime.Serialization;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class ExtendedEntityMediaModel
    {
        [DataMember(Name = "media_url")]
        public string MediaUrl { get; set; }
        [DataMember(Name = "media_url_https")]
        public string MediaUrlHttps { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "DisplayUrl")]
        public string display_url { get; set; }
        [DataMember(Name = "expanded_url")]
        public string ExpandedUrl { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "video_info")]
        public VideoInfoModel VideoInfo { get; set; }
    }

}
