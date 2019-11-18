using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class HotelDetails : HotelIdentifier
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public float DistanceToCenter { get; set; }
        [DataMember]
        public int StarRating { get; set; }

        [DataMember]
        public List<RoomIdentifier> Rooms { get; set; }

        public HotelDetails(int id) : base(id)
        {
        }
    }
}
