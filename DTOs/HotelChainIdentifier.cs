using System.Runtime.Serialization;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class HotelChainIdentifier
    {
        [DataMember]
        public int ID { get; set; }

        public HotelChainIdentifier(int id)
        {
            ID = id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            var other = obj as HotelChainIdentifier;
            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}