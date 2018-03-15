using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    internal class BysykkelAvailabilityStation
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public BysykkelAvailability availability { get; set; }
    }
}