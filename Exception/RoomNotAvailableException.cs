using System.Runtime.Serialization;

namespace HotelSystem.Exception
{
    [DataContract]
    public class RoomNotAvailableException : System.Exception
    {
    }
}