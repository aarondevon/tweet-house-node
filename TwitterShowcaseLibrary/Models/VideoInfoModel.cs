using System.Runtime.Serialization;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class VideoInfoModel
    {
        [DataMember(Name = "aspect_ratio")]
        public int[] AspectRatio { get; set; }
        [DataMember(Name = "duration_millis")]
        public int DurationMillis { get; set; }
        [DataMember(Name = "variants")]
        public VideoVariantModel[] Variants { get; set; }
    }

}
