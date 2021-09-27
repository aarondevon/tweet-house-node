using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitterShowcaseLibrary.Models
{
    [DataContract]
    public class EntityModel
    {
        [DataMember(Name = "hashtags")]
        public object[] Hashtags { get; set; }
        [DataMember(Name = "symbols")]
        public object[] Symbols { get; set; }
        [DataMember(Name = "user_mentions")]
        public object[] UserMentions { get; set; }
        [DataMember(Name = "urls")]
        public List<UrlModel> Urls { get; set; }
    }
}
