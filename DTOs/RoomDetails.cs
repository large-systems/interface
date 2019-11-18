using System.Runtime.Serialization;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class RoomDetails : RoomIdentifier
    {

        public int _id;
        public int _roomNumber;
        public string _roomType;
        public double _price;
        public int _capacity;


     

        [DataMember]
        public int RoomNumber { get; set; }
        [DataMember]
        public string RoomType { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Capacity { get; set; }

        public RoomDetails(int id) : base(id)
        {
            
        }
    }
}