using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    public class BysykkelStation
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public bool in_service { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string subtitle { get; set; }

        [DataMember]
        public int number_of_locks { get; set; }

        [DataMember]
        public Position center { get; set; }

        [DataMember]
        public Position[] bounds { get; set; }

        /// <summary>
        /// Add availability data from /availability
        /// </summary>
        public BysykkelAvailability availability { get; set; } 

    }
}