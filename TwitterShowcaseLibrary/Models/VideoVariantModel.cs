using System.Runtime.Serialization;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class VideoVariantModel
    {
        [DataMember(Name = "bitrate")]
        public int BitRate { get; set; }
        [DataMember(Name = "content_type")]
        public string ContentType { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }

}
