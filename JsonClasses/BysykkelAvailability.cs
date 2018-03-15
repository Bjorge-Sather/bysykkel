using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    public class BysykkelAvailability
    {
        [DataMember]
        public int bikes { get; set; }

        [DataMember]
        public int locks { get; set; }
    }
}