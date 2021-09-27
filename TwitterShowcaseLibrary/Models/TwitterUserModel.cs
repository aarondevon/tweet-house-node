using System.Runtime.Serialization;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class TwitterUserModel
    {
        [DataMember(Name = "id")]
        public double Id { get; set; }
        [DataMember(Name = "id_str")]
        public string IdString { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "screen_name")]
        public string ScreenName { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "profile_background_color")]
        public string ProfileBackgroundColor { get; set; }
        [DataMember(Name = "profile_background_image_url_https")]
        public string ProfileBackgroundImageUrl { get; set; }
        [DataMember(Name = "profile_image_url_https")]
        public string ProfileImageUrl { get; set; }
        [DataMember(Name = "profile_banner_url")]
        public string ProfileBannerUrl { get; set; }
    }
}
