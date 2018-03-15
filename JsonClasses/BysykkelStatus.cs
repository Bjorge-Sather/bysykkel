using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    public class BysykkelStatus
    {
        [DataMember]
        public bool all_stations_closed { get; set; }
        /// <summary>
        /// Without knowing, I assume that stations_closed will be an array of station ids
        /// </summary>
        [DataMember]
        public int[] stations_closed { get; set; }

    }
}
