using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.Models
{
    public class Reservation
    {

        public RoomID RoomID { get; }
        public string Username { get; }// this will be used for view
        public DateTime StartTime { get;}

        public DateTime EndTime { get;}

        public TimeSpan length=> EndTime.Subtract(StartTime);

        public Reservation(RoomID roomID,string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
                     
        }
     

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartTime < EndTime || reservation.EndTime > StartTime;
        }
    }
}
