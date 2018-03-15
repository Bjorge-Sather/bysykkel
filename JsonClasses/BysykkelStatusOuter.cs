using System.Runtime.Serialization;

namespace bysykkel
{
    [DataContract]
    public class BysykkelStatusOuter
    {
        [DataMember]
        public BysykkelStatus status { get; set; }

    }
}
