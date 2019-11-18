using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelInterface.DTOs
{
    [DataContract(IsReference = true)]
    public class HotelDetails : HotelIdentifier
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public float DistanceToCenter { get; set; }
        public int StarRating { get; set; }

        public List<RoomIdentifier> Rooms { get; set; }

        public HotelDetails(int id) : base(id)
        {
        }
    }
}
