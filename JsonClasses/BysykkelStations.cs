using System.Collections.Generic;
using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    internal class BysykkelStations
    {
        [DataMember]
        public List<BysykkelStation> stations { get; set; }

    }
}