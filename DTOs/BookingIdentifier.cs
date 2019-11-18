using System.Runtime.Serialization;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class BookingIdentifier
    {
        [DataMember]
        public int ID { get; set; }

        public BookingIdentifier(int id)
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
            var other = obj as BookingIdentifier;
            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            var hashCode = -867290869;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            return hashCode;
        }
    }
}