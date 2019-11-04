using System.Runtime.Serialization;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class RoomIdentifier
    {
        public int ID { get; set; }

        public RoomIdentifier(int id)
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
            var other = obj as RoomIdentifier;
            return ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}