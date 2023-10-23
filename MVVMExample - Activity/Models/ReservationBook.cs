using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The models
namespace MVVMExample.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation>_reservations;
    

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r=> r.Username == username);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation ExistingReservation in _reservations)
            {
                if(ExistingReservation.Conflicts(reservation))
                {
                    _reservations.Add(reservation);
                }
            }

      
        }
    }
}
