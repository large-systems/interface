using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelInterface.DTOs
{
    [DataContract]
    public class BookingDetails : BookingIdentifier
    {
        public DateTime _startDateTime;
        public DateTime _endDate;
        public int _numberOfGuests;
        public int _numberOfRooms;
        public DateTime _arrival;
        public List<RoomDetails> _listOfRoomsDetails;

        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int NumberOfRooms { get; set; }
        [DataMember]
        public DateTime Arrival { get; set; }

        [DataMember]
        public List<RoomDetails> ListOfRoomsDetails { get; set; }


        public BookingDetails(int id) : base(id)
        {
        }
    }
}