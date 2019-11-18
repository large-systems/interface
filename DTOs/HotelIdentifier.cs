using System.Runtime.Serialization;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class HotelIdentifier
    {
        [DataMember]
        public int ID { get; set; }

        public HotelIdentifier(int id)
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
            var other = obj as HotelIdentifier;
            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}
