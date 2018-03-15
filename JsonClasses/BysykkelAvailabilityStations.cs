using System.Collections.Generic;
using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    internal class BysykkelAvailabilityStations
    {
        [DataMember]
        public List<BysykkelAvailabilityStation> stations { get; set; }

    }
}