using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    public class Position
    {
        [DataMember]
        public float latitude { get; set; }

        [DataMember]
        public float longitude { get; set; }
    }
}